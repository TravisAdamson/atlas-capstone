# R.E.S.T. (Remembrance End-of-Life Services & Tracking)

## Overview
Welcome to the **R.E.S.T.** (Remembrance End-of-Life Services & Tracking) project! This application is designed to help users efficiently manage end-of-life service records, including product and service selection, contract creation, and obituary management. The goal of this project is to streamline the process for funeral homes or other service providers by allowing them to manage their clients' services in one integrated system.

## Table of Contents
- [Project Description](#project-description)
- [Tech Stack](#tech-stack)
- [Features](#features)
- [Project Team](#project-team)
- [User Experience](#user-experience)
- [Installation](#installation)
- [Challenges](#challenges)
- [Learning Objectives](#learning-objectives)
- [Contributing](#contributing)
- [License](#license)

## Project Description
R.E.S.T. allows the user to manage **end-of-life** services in an efficient, organized way. The system provides features for:
- Creating new records containing all primary client information.
- Adding and managing obituary details.
- Selecting products and services from a predefined price list.
- Generating contracts that include the necessary legal information.

This project will provide a seamless experience for users managing sensitive end-of-life data, with a focus on ease of use and clear data presentation.

## Tech Stack
Our application is built with the following technologies:
- **Frontend:** Blazor, HTML, CSS, JavaScript
- **Backend:** ASP.NET Core, C#
- **Database:** MySQL
- **Other Tools:** Docker (for containerization), Visual Studio (IDE)

## Features
- **Single Screen Record Entry:** Users can quickly enter all primary information for a new record on a single screen.
- **Obituary Management:** Users can add and edit obituary content for each record.
- **Service & Product Selection:** A dynamic price list allows users to select services and products based on their preferences.
- **Contract Generation:** Automatically generate a contract, including necessary legal details, based on selected services and products.
- **Responsive Design:** Fully responsive UI, designed to work on desktop and mobile devices.

## Project Team
The project team is composed of the following roles:
- **Travis Adamson:** Project Manager
- **Nolan Heald:** Quality Assurance, SDET
- **Kevin Vang:** Front-End Development
- **Matt Ernst:** Back-End Development

## User Experience
The **R.E.S.T.** system offers a simple and intuitive interface for end-users:
1. **Home Screen:** A welcoming dashboard with easy access to all features.
2. **Record Entry Screen:** A straightforward form to input essential details about the deceased and the funeral service.
3. **Contract Creation Screen:** After selecting services and products, users can generate a detailed contract that includes all necessary legal information.

The application is designed to be intuitive for funeral service providers, reducing the complexity of tracking and managing end-of-life services.

## Installation
To get the project up and running locally, follow these steps:

### Prerequisites
- .NET 5 or higher
- MySQL Server
- Visual Studio or Visual Studio Code

### Steps to Install
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/rest-project.git
    cd rest-project
    ```

2. Set up the MySQL database:
    - Create a database called `rest_db` in MySQL.
    - Import the provided `schema.sql` to set up the necessary tables.

3. Configure your MySQL connection string:
    - Open `appsettings.json` and update the connection string under `ConnectionStrings`:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=rest_db;User=root;Password=yourpassword;"
    }
    ```

4. Build and run the project:
    ```bash
    dotnet build
    dotnet run
    ```

Visit `http://localhost:5000` in your browser to access the application.

## Challenges
- **New Tech Stack:** Learning to work with the latest tech stacks like ASP.NET Core, Blazor, and MySQL posed a challenge for the team, but we embraced it as an opportunity for growth.
- **Scheduling:** Coordinating schedules to ensure consistent progress across all parts of the project was a bit tricky.
- **Client Needs/Requirements:** Aligning the features with the client's expectations while ensuring technical feasibility required ongoing discussions.

## Learning Objectives
- **Tech Stack Mastery:** Familiarity with ASP.NET, Blazor, MySQL, C#, and other tools in the tech stack.
- **Database Design:** Understanding of effective database management practices, especially for handling sensitive data.
- **Project Management:** Learning how to manage deadlines, allocate tasks, and ensure clear communication within the team.
- **Client Interaction:** Developing best practices for interacting with clients and meeting their requirements.
  
## Contributing
We welcome contributions to improve **R.E.S.T.**! If you have suggestions, bug fixes, or feature enhancements, feel free to create an issue or submit a pull request.

### Steps to Contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Make your changes and commit them (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/your-feature-name`).
5. Create a new pull request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

> **Note:** This is a simplified overview of the project for development purposes. The final product will be continuously improved based on feedback and testing.


