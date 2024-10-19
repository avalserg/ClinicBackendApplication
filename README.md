# Clinic

## Introduction

Application for manage Clinic by using modern approaches of development on the ASP.NET platform with microcervices architecture.

## Architecture design patterns used

- RESTful
- CQRS
- Mediator
- Clean Architecture
- Repository
- Write-through cache
- DDD
- Value objects

## Libraries

- .NET 8 
- ASP.NET 8
- AutoMapper 13
- FluentValidation 11
- MediatR 12
- Serilog 3
- EntityFrameworkCore 8
- MassTransit

## Tools

- Redis
- Docker
- gRPC
- RabbitMQ

## Projects

### Application

![_240624220202](https://github.com/user-attachments/assets/0773e248-52b4-4faf-9298-db39e4e6bbf5)

#### AuthorizationMicroservice

- Authorization.Api - Common middlewares and api services configuration
- Authorization.Application - Core business logic abstractions and realizations 
- Authorization.Persistence - Database connection realizations
- Authorization.Domain - RefreshToken entity
- Authorization.ExternalProviders -Add HttpClient for connect with ManageUsersMicroService 


#### ManageUsersMicroservice

- ManageUsers.Api - Common middlewares and api services configuration
- ManageUsers.Application - Core business logic abstractions and realizations 
- ManageUsers.Persistence - Database connection realizations
- ManageUsers.Domain - Administrator, ApplicationUser, ApplicationUserRole, Doctor,  Patient entities


#### MedicalCardsMicroservice

- MedicalCards.Api - Common middlewares and api services configuration
- MedicalCards.Application - Core business logic abstractions and realizations 
- MedicalCards.Persistence - Database connection realizations
- MedicalCards.Domain - Appointment, MedicalCard, Prescription entities
- MedicalCards.ExternalProviders -Add gRPC Client for connect with ManageUsersMicroService 


#### PatientTicketsMicroservice

- PatientTickets.Api - Common middlewares and api services configuration
- PatientTickets.Application - Core business logic abstractions and realizations 
- PatientTickets.Persistence - Database connection realizations
- PatientTickets.Domain - PatientTicket entity
- PatientTickets.ExternalProviders -Add gRPC Client for connect with ManageUsersMicroService


 #### ReviewsMicroservice

- Reviews.Api - Common middlewares and api services configuration
- Reviews.Application - Core business logic abstractions and realizations 
- Reviews.Persistence - Database connection realizations
- Reviews.Domain - Review entity
- Reviews.ExternalProviders -Add gRPC Client for connect with ManageUsersMicroService 



