# Number Converter

This is a simple program that converts numeric values to their word representations.

## Prerequisites

Before running the program, ensure that you have the following prerequisites installed on your system:

Docker: Make sure you have Docker installed on your system. You can download and install Docker from the official website: https://www.docker.com/get-started
Please note that the Dockerfile provided in the repository takes care of the necessary dependencies and ensures the correct version of .NET Core is used within the Docker container. Therefore, you don't need to separately install the .NET Core SDK on your system. Docker will handle the installation and configuration of the required runtime environments.

## How to Use



1. Ensure that you have Docker installed on your system.
   Checking Docker Installation

   Open a terminal or command prompt.
   Run the following command:
   ```
   docker --version

   ```
   If Docker is not installed, follow the steps below to install it:

   * Visit the Docker website: https://www.docker.com.
   * Navigate to the Downloads section of the website.
   * Choose the appropriate version of Docker for your operating system (e.g., Docker Desktop for Windows/Mac, Docker Engine for Linux).
   * Follow the installation instructions provided on the Docker website for your specific operating system.
   * Once Docker is installed, verify the installation by running the docker --version command again.

2. Clone the repository to your local machine:
```
git clone https://github.com/moeketsisegalo/Code_Reviewer_Test.git
```
2. Change to the project directory:
```
cd Code_Reviewer_Test
```
2. Build the Docker image:
```
docker build -t code_challenge .
```

![Build App](https://raw.githubusercontent.com/moeketsisegalo/Code_Reviewer_Test/main/Section_C/screenshots/build_app.png)


3.Run the Docker container:
```
docker run code_challenge
```
![Run App](Section_C/screenshots/run_app.png)
The program will execute and display the word representations of the provided numeric values.
