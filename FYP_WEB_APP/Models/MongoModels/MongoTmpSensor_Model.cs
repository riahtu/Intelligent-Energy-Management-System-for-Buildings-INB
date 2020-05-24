﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_WEB_APP.Models.MongoModels
{
    public class MongoTmpSensor_Model
    {
        public ObjectId _id { get; set; }
        public string sensorId { get; set; }
        public double current { get; set; }
        public DateTime latest_checking_time { get; set; }
    }
}
