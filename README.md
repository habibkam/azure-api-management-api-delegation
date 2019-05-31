# azure-api-management-api-delegation

This web application demonstrates how to delegate user registration and product subscription using your exiting website.
It has been adpated from source code from this [web application](https://github.com/Azure/api-management-samples/tree/master/delegation#microsoft-azure-api-management-delegation-sample) to use the new APIM resource group Rest api encapsulated in a web API proxy service.

Please, refer to [APIM docs](https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-setup-delegation/) for full documentation. This application uses [Azure API Management Proxy service](https://github.com/habibkam/azure-api-management-api-proxy), to create/register user and creating/deleting product subscriptions in APIM.

## Requirements

You have:
- follow the [requirements](https://github.com/habibkam/azure-api-management-api-proxy#requirements) for APIM Proxy service
- setup localdb for the web application user registration and update the connectionstring in web.config
- setup APIM with the plan url of your web application and generate the key
- update Account controller code with your APIM settings:
    * string ApimProxyEndpoint = "your apim proxy endpoint";
    * string ApimDevPortalSignoutUrl = "https://your dev portal/signout";
    * string ApimDevPortalDevUrl = "https://your dev portal/developer";
    * string ApimDelegationKey = "your generated delegation ke>";
- deploy the web application
- launch the APIM dev portal and start testing


## Deployment

### Local

Build and deploy the web api locally.
BUild and deploy the web application locally
You can use an app like Postman to test the endpoints.

### Public

The web API doesn't offer any authentication mechanism.
If you plan to expose it to the web you should supplement it with authentication mechanism.
