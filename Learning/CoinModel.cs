using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Bpi
    {
        [JsonPropertyName("USD")]
        public USD USD { get; set; }

        [JsonPropertyName("GBP")]
        public GBP GBP { get; set; }

        [JsonPropertyName("EUR")]
        public EUR EUR { get; set; }
    }

    public class EUR
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rate_float")]
        public double RateFloat { get; set; }
    }

    public class GBP
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rate_float")]
        public double RateFloat { get; set; }
    }

    public class CoinModel
    {
        [JsonPropertyName("time")]
        public Time Time { get; set; }

        [JsonPropertyName("disclaimer")]
        public string Disclaimer { get; set; }

        [JsonPropertyName("chartName")]
        public string ChartName { get; set; }

        [JsonPropertyName("bpi")]
        public Bpi Bpi { get; set; }
    }

    public class Time
    {
        [JsonPropertyName("updated")]
        public string Updated { get; set; }

        [JsonPropertyName("updatedISO")]
        public DateTime UpdatedISO { get; set; }

        [JsonPropertyName("updateduk")]
        public string Updateduk { get; set; }
    }

    public class USD
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("rate_float")]
        public double RateFloat { get; set; }
    }

