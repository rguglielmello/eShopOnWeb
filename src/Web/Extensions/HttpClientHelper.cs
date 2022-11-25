namespace Microsoft.eShopWeb.Web.Extensions;

public class HttpClientHelper : HttpClient
{
    public HttpClientHelper(string header, string value)
    {
        if (header == null)
            throw new ArgumentNullException(nameof(header));
        if (value == null)
            throw new ArgumentNullException(nameof(value));

        DefaultRequestHeaders.Add(header, value); 
    }
}
