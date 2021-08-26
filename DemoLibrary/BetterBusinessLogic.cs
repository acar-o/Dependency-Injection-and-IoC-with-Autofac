using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            //Logger logger = new();
            //DataAccess dataAccess = new();

            _logger.Log("Better Starting the processing of data.");
            Console.WriteLine("Better Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Better Processed info");
            _logger.Log("Finishing Better processing of the data.");
        }
    }
}
