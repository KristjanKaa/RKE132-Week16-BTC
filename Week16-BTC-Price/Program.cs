

using Newtonsoft.Json;
using System.Net;
using Week16_BTC_Price;

BitCoinRate bitcoin = GetRates();

Console.WriteLine($"Praegune BTC hind $:  {bitcoin.bpi.USD.rate_float} {bitcoin.bpi.USD.code}");

static BitCoinRate GetRates()
{
    string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";

    var webResponse = request.GetResponse();
    var webStreame = webResponse.GetResponseStream();

    BitCoinRate bitcoinRate;
    using (var responseReader = new StreamReader(webStreame))
    {
        var response = responseReader.ReadToEnd();
        bitcoinRate = JsonConvert.DeserializeObject<BitCoinRate>(response);
    }
    return bitcoinRate;
}