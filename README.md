# msa-Databases-API-2020

**URL for my API** : https://msa-studentsims2-webapp.azurewebsites.net

## API Description: 

Address table was created with the specified attributes (StudentId as a foreign key, street number, street, suburb, city, postcode and country). One-to-many relationship between Address and Student was created using virtual nagivation property.

Basic CRUD requests for both Student and Address table were made through basic API controllers created by scaffolding. Extra Post and Put API methods were created. The new Post method adds new address for a student using his/her StudentID. The new Put method changes the address of a student using his/her StudentID.
