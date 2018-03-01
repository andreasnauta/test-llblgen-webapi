# Introduction
This is a test repository for testing ASP.NET Core Web Application with LLBLGen. It's been created rather quickly to test a few things and is therefore missing things like unit test (and not thoroughly tested).

# Requirements
- SQL Server 2017 Express Edition.

# Usage (not tested on other computers yet)
1. Run the script in the SQL folder to create the database.
2. Change the connection string in the StartUp.cs class in the WebAPI project (if it is anything else than localhost).
3. Run the WebAPI project.

The code generated by LLBLGen is already included, so there should be no need to do anything else.

# The Model
## Item
- Item (Abstract)
- DomainItem Abstract, Inherits from Item)
- SpecificItem (Inherits from DomainItem)

## Basedata
- Collection (used on both Actor and Item)

## Incident
- Incident (Something happens to an Item)
- ActorIncident (Relationship table, an actor is related to an incident)

## Actor
- Actor (Abstract)
- PersonActor (Inherits from Actor)

## Improvements
Lots, most importantly it could use a generic repository.