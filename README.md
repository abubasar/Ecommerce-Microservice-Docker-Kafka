# Ecommerce Microservice Project

## Overview

This project is an Ecommerce microservice application consisting of two primary services:

- **Product Service**: Manages the list of products and their stock levels.
- **Order Service**: Handles ordering of products and interacts with the Product Service to update stock levels.

**Kafka** is used for asynchronous communication between the Product Service and the Order Service to update stock levels in real-time.

## Architecture

- **Product Service**: Provides endpoints to list products and update stock.
- **Order Service**: Allows users to place orders, which triggers stock updates in the Product Service via Kafka.

## Technologies Used

- **.NET Core 8**: For creating the microservices.
- **Kafka**: For handling asynchronous communication and stock updates.
- **Docker**: For containerization.
- **SQL Server**: For database management.

## Getting Started

### Prerequisites

- .NET Core 8
- Apache Kafka
- Docker
- SQL Server

### Setup

1. **Clone the Repository**

   ```bash
   git clone https://github.com/abubasar/Ecommerce-Microservice-Docker-Kafka.git
   cd Ecommerce-Microservice-Docker-Kafka
