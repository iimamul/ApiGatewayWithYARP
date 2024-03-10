# API Gateway with YARP and Docker compose

- This api gateway will forward all request to Product.API and Shop.API

- `http://localhost:5000/shop/api/shops` this request will be redirected to `http://host.docker.internal:6000/api/shops`. That is exposed in `http://localhost:6000/api/shops`

- `http://localhost:5000/product/api/Products` this request will be redirected to `http://host.docker.internal:6100/api/Products`. That is exposed in `http://localhost:6100/api/Products`

- use `host.docker.internal` insted of service name like `shop.api`. In my case it's not working, and for more details follow this [issue](https://github.com/microsoft/reverse-proxy/issues/2301)
