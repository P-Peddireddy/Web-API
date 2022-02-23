Get Customer with the id 1

GET:  https://localhost:5001/api/customers/1


List All Customers:

GET:  https://localhost:5001/api/Customers


Add New Customers:

POST : https://localhost:5001/api/customers

HEADERS

Content-Type : application/json
BODY : raw

{
	"Name":"Lucas Owen ",
	"Email":"Lucas12@aol.com"
}

Delete a Customer :

DEL :https://localhost:5001/api/customers/4
 

 
HEADERS


Content-Type : application/json

Update customers details:

PUT https://localhost:5001/api/customers/1
 


HEADERS

Content-Type : application/json
BODY 

raw

{
	"name":"sara",
	"Email":"a@b.com"
}