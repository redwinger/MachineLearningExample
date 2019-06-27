using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearningExample.Data.Models
{
    public class TaxiTripFareAmountPrediction
    {
        [ColumnName("Score")]
        public float FareAmount;
    }
}
