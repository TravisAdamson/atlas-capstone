import os
import pandas as pd
from sqlalchemy import create_engine, inspect

# --- CONFIGURE THESE ---
db_username = 'travis'
db_password = 'travis'
db_host = 'localhost'
db_name = 'restdb'
csv_folder_path = '/home/travis/atlas-capstone/RESTDB/Faker/'
# ------------------------

# Create SQLAlchemy engine
engine = create_engine(f'mysql+mysqlconnector://{db_username}:{db_password}@{db_host}/{db_name}')

# Create inspector to get table schemas
inspector = inspect(engine)

# Get a list of existing tables in the DB (case-insensitive)
existing_tables = {table.lower(): table for table in inspector.get_table_names()}

for file in os.listdir(csv_folder_path):
    if file.endswith('.csv'):
        file_path = os.path.join(csv_folder_path, file)
        table_guess = os.path.splitext(file)[0]
        table_actual = existing_tables.get(table_guess.lower())  # match ignoring case

        if not table_actual:
            print(f"⚠️  No matching table for file: {file} — skipping.")
            continue

        try:
            df = pd.read_csv(file_path)

            if df.empty:
                print(f"⚠️  File {file} is empty — skipping.")
                continue

            # Check if all CSV columns exist in the table
            table_columns = [col["name"] for col in inspector.get_columns(table_actual)]
            missing_cols = [col for col in df.columns if col not in table_columns]

            if missing_cols:
                print(f"⚠️  {file} has unexpected columns not in table {table_actual}: {missing_cols} — skipping.")
                continue

            df.to_sql(table_actual, con=engine, if_exists='append', index=False)
            print(f"✅ Imported {len(df)} records from {file} → {table_actual}")
        except Exception as e:
            print(f"❌ Failed to import {file} → {table_actual}: {e}")
