using MyntraDemoProject.PageObjects;
using MyntraDemoProject.Utilities;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.TestScripts
{
    internal class CarrerTest: CoreCodes
    {
        [Test]
        public void CarrerInfo()
        {
            List<CareerData> CareerList;
            string? currDir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currDir + "/Logs/log_" +
               DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
           .WriteTo.Console()
           .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
           .CreateLogger();
            

           /* string? excelFilePath = currdir + "/TestData/InputData.xlsx";
            string? sheetName = "Career";*/

            var car = new MyntraHomePage(driver);
            car.CareersClick();
            var exp = new ExploreCareers(driver);
            exp.ExpCareerClick();
            var tec= new Technology(driver);
            tec.Technologyclick();
            var Data = new DataEngineers(driver);
            Data.DataEngClick();
            var labu = new ApplyLast(driver);
            labu.LastButtonClick();

            string? excelFilePath = currDir + "/TestData/InputData.xlsx";
          string? sheetName = "Career";
            CareerList = CareerUtilities.ReadExcelData(excelFilePath, sheetName);

            foreach (var cdata in CareerList)
            {
                string? firstName = cdata.FirstNameInputBox;
                string? lastName = cdata.LastNameInputBox;
                string? email= cdata.EmailInputBox;
                string? mbno = cdata.PhoneNum;
                string? location = cdata.Location;
                Thread.Sleep(3000);
                labu.ApplyNow(firstName, lastName, email, mbno, location);
            }

        }
    }
}
