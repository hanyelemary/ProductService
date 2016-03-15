ProductService
==============

This is a simple proof-of-concept implementation for Nancy microservices in .NET. For more information on Nancy, please see the documentation on ([Nancy](http://nancyfx.org/)).

## Project organization

* Models: Where model objects are stored (Product.cs is the only one)
* Modules: Where the ProductService is stored. This can be named anything.

## API endpoints

* GET /products -- get all products
* GET /products/id -- get product by id

In order for content negotiation to work, you need to set the following request headers:
```
Content-Type: application/json
Accept: application/json
```

## Running the application

You can run the solution using visual studio and test it using Postman.


## Testing

Nancy.Testing is used with xUnit. The "Modules" folder includes a single xUnit test that runs using a "headless browser" with no dependency on network, browser or any of the other .NET packages such as System.Web. 

Currently, there is 2 passing tests and 1 failing test (a test that hasn't been implemented).