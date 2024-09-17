Ecommerce Microservice Project
Overview
This project is an Ecommerce microservice application consisting of two primary services:

Product Service: Manages the list of products and their stock levels.
Order Service: Handles ordering of products and interacts with the Product Service to update stock levels.
Kafka is used for asynchronous communication between the Product Service and the Order Service to update stock levels in real-time.

Architecture
Product Service: Provides endpoints to list products and update stock.
Order Service: Allows users to place orders, which triggers stock updates in the Product Service via Kafka.
Technologies Used
Spring Boot: For creating the microservices.
Kafka: For handling asynchronous communication and stock updates.
Docker: For containerization.
SQL SERVER: For database management.
Getting Started
Prerequisites
Dotnet Core 8
Apache Kafka
Docker
A database system (MS SQL SERVER)
Setup
Clone the Repository

bash
Copy code
git clone https://github.com/abubasar/Ecommerce-Microservice-Docker-Kafka.git
cd ecommerce-microservice-project

 you can start Kafka with the provided docker-compose file.

bash
Copy code
cd docker
docker-compose -f kafka.yml up
Configure Database

Ensure that your database is up and running. Configure the database settings in the application.properties file of each service.
