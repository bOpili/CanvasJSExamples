using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CanvasJSExamples.Models;
using Newtonsoft.Json;  //Do serializacji danych 

namespace CanvasJSExamples.Controllers
{
    public class CanvasjsController : Controller
    {
        //Generator liczb losowych
        public Random random;
        
        public CanvasjsController()
        {
            random = new Random();
        }


        // Defalut plot for ploting linear chart using Canvasjs library 
        // GET: Canvasjs
        public ActionResult Index()
        {
            double N = 10000; //liczba punktów
            double y = 100; //wartość dla osi OY
            //Dane do rysowania wykresu liniowego (losowe)

            List<DataPoint> dataPoints = new List<DataPoint>();

            for(int i=0;i<N;i++)
            {
                y += random.Next(-20, 20);
                dataPoints.Add(new DataPoint(i, y));
            }

            //Zwrócenie danych do widoku Indeks w celu narysowania przy użyciu Canvasjs
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            //Zwrócenie widoku
            return View();
        }

        public ActionResult Funkcja1() {

            //double N = 500;
            double y;

            List<DataPoint> dataPoints = new List<DataPoint>();
            
            for (double i = -5; i < 5; i += 0.01) {
                y = Math.Sin(5 * i) + Math.Cos(3 * i);
                dataPoints.Add(new DataPoint(i, y));

                ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            }

            return View();
        }

        public ActionResult Funkcja2() {
            double y;

            List<DataPoint> dataPoints = new List<DataPoint>();

            for (double i = -5; i < 5; i += 0.01) {
                y = Math.Pow(i,2)-10*Math.Cos(2*Math.PI*i)+10;
                dataPoints.Add(new DataPoint(i, y));

                ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            }

            return View();
        }

        public ActionResult ColumnChart() {

            List<DataPerson> dataPersons = new List<DataPerson>();

            dataPersons.Add(new DataPerson("Adam", random.Next(10, 100)));
            dataPersons.Add(new DataPerson("Tomasz", random.Next(10, 100)));
            dataPersons.Add(new DataPerson("Martyna", random.Next(10, 100)));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPersons);


            return View();
        }

        public ActionResult PieChart() {

            List<DataPerson> dataPersons = new List<DataPerson>();

            dataPersons.Add(new DataPerson("Adam", random.Next(10,100)));
            dataPersons.Add(new DataPerson("Tomasz", random.Next(10, 100)));
            dataPersons.Add(new DataPerson("Martyna", random.Next(10, 100)));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPersons);


            return View();
        }

        public ActionResult CombinationChart() {

            List<DataCombination> dataCombination1 = new List<DataCombination>();
            List<DataCombination> dataCombination2 = new List<DataCombination>();
            List<DataCombination> dataCombination3 = new List<DataCombination>();

            dataCombination1.Add(new DataCombination(random.Next(0, 10), random.Next(0, 10), "Tomasz"));
            dataCombination1.Add(new DataCombination(random.Next(10, 30), random.Next(10, 30), "Adam"));
            dataCombination1.Add(new DataCombination(random.Next(30, 50), random.Next(30, 50), "Martyna"));


            dataCombination2.Add(new DataCombination(random.Next(0, 10), random.Next(0, 10), "Tomasz"));
            dataCombination2.Add(new DataCombination(random.Next(10, 30), random.Next(10, 30), "Adam"));
            dataCombination2.Add(new DataCombination(random.Next(30, 50), random.Next(30, 50), "Martyna"));

            dataCombination3.Add(new DataCombination(random.Next(0, 10), random.Next(0, 10), "Tomasz"));
            dataCombination3.Add(new DataCombination(random.Next(10, 30), random.Next(10, 30), "Adam"));
            dataCombination3.Add(new DataCombination(random.Next(30, 50), random.Next(30, 50), "Martyna"));


            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataCombination1);
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataCombination2);
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataCombination3);

            return View();
        }
    }
}