using Nancy;
using Nancy.Testing;
using System;
using Xunit;

namespace ProductService.Modules
{
    public class ProductServicesTests
    {
        private Browser browser = new Browser(with =>
            with.Module(new ProductService())
        );

        [Fact]
        public void Should_return_status_ok_when_route_exists()
        {
            var result = GetRequest("/products");
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]
        public void Should_echo_product_id_in_response()
        {
            var result = GetRequest("/products/2");
            Assert.Equal("Product with id 2", result.Body.AsString());
        }

        [Fact]
        public void Should_return_status_not_found_for_undefined_products()
        {
            var result = GetRequest("/products/3");
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
        }

        private BrowserResponse GetRequest(String path)
        {
            var result = browser.Get(path, with =>
            {
                with.Header("Accept", "application/json");
                with.Header("Content-Type", "application/json");
                with.HttpRequest();
            });
            return result;
        }
    }
}