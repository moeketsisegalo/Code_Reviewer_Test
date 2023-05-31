# Number Converter

This is a simple program that converts numeric values to their word representations.

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


2. Build the Docker image:
```
docker build -t code_challenge .
```
3.Run the Docker container:
```
docker run code_challenge
```
The program will execute and display the word representations of the provided numeric values.
