using Microsoft.ML.Data;

namespace CP_ML.Models
{
    public class ModelOutput
    {
        [ColumnName(@"CurrencyRate")]
        public float CurrencyRate { get; set; }

        [ColumnName(@"EMA10")]
        public float EMA10 { get; set; }

        [ColumnName(@"EMA12")]
        public float EMA12 { get; set; }

        [ColumnName(@"EMA17")]
        public float EMA17 { get; set; }

        [ColumnName(@"EMA21")]
        public float EMA21 { get; set; }

        [ColumnName(@"EMA100")]
        public float EMA100 { get; set; }

        [ColumnName(@"EMA200")]
        public float EMA200 { get; set; }

        [ColumnName(@"EMA26")]
        public float EMA26 { get; set; }

        [ColumnName(@"MACD")]
        public float MACD { get; set; }

        [ColumnName(@"Signal")]
        public float Signal { get; set; }

        [ColumnName(@"RSI")]
        public float RSI { get; set; }

        [ColumnName(@"Features")]
        public float[]? Features { get; set; }

        [ColumnName(@"Score")]
        public float Score { get; set; }

    }

    public class ModelInput
    {
        [LoadColumn(0)]
        [ColumnName(@"CurrencyRate")]
        public float CurrencyRate { get; set; }

        [LoadColumn(1)]
        [ColumnName(@"EMA10")]
        public float EMA10 { get; set; }

        [LoadColumn(2)]
        [ColumnName(@"EMA12")]
        public float EMA12 { get; set; }

        [LoadColumn(3)]
        [ColumnName(@"EMA17")]
        public float EMA17 { get; set; }

        [LoadColumn(4)]
        [ColumnName(@"EMA21")]
        public float EMA21 { get; set; }

        [LoadColumn(5)]
        [ColumnName(@"EMA100")]
        public float EMA100 { get; set; }

        [LoadColumn(6)]
        [ColumnName(@"EMA200")]
        public float EMA200 { get; set; }

        [LoadColumn(7)]
        [ColumnName(@"EMA26")]
        public float EMA26 { get; set; }

        [LoadColumn(8)]
        [ColumnName(@"MACD")]
        public float MACD { get; set; }

        [LoadColumn(9)]
        [ColumnName(@"Signal")]
        public float Signal { get; set; }

        [LoadColumn(10)]
        [ColumnName(@"RSI")]
        public float RSI { get; set; }
    }

    public class TrainResult
    {
        public double MeanCrossValidatedR2 { get; set; }
        public double RSquared { get; set; }
        public double MeanAbsoluteError { get; set; }
        public double MeanSquaredError { get; set; }
        public double RootMeanSquaredError { get; set; }
        public double LossFunction { get; set; }
        public string? TrainerType { get; set; }
        public string? ModelLocation { get; set; }
    }
    
}
