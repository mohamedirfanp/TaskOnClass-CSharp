using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._31_03_2023
{
    internal class ArrangementAsync
    {


        async public Task ArrangementAsyncMain()
        {

            DecorationOfStage();
            Console.WriteLine("The work is completed");


            await ChiefGuestGuideLines();

            SpeechReview();
            Console.WriteLine("The speech review is completed");

            var foodprepactivity = FoodPrepActivity();


            GetPrizes();
            Console.WriteLine("The Prizes are arrived");

            

            
            // The program start is must called after ChiefGuestGuideLines();
            

            Console.Read();

        }


        async public Task ChiefGuestGuideLines()
        {
            var pickupGuest = PickUpGuest();
            CheckVenue();
            Console.WriteLine("The venue is SAFE!!!");
            return;
        }

        async public Task FoodPrepActivity()
        {
            var raw_material = FoodRawMaterial();
            Console.WriteLine("The food material is dropped");
            PrepFood();
            Console.WriteLine("The food is prepped");
            return;
        }


        async public Task ProgramStart()
        {
            ChiefGuestSpeech();
            DistributePrize();
            ProvideFoood();

            return;

        }


        
        async public Task PickUpGuest()
        {
            Console.WriteLine("The Car is send to pick up chief guest from the airport");
            await Task.Delay(8000);
            Console.WriteLine("The car arrivied in the venue");
            return;
        }

        async public void DecorationOfStage()
        {
            Console.WriteLine("The stage decoration work is started");
        }


        async public Task FoodRawMaterial()
        {
            Console.WriteLine("The food raw is arrived in the venue");
            await Task.Delay(2000);
            return;
        }

        


        async public void PrepFood()
        {
            Console.WriteLine("The catering started to prepare food");
        }

        async public void SpeechReview()
        {
            Console.WriteLine("The speech review is started by PA");
        }

        async public void CheckVenue()
        {
            Console.WriteLine("The venue is started to check for unwanted threads");
        }

        async public Task GetPrizes()
        {
            Console.WriteLine("The Prizes is arrived at the venue");
            await Task.Delay(5000);
            return;
        }

        async public Task DistributePrize()
        {
            Console.WriteLine("The prize is distributed is started");
            await Task.Delay(5000);
            return;
        }
        async public Task ChiefGuestSpeech()
        {
            Console.WriteLine("The Chief Guest speech started");
            await Task.Delay(3000);
            return;
        }
        async public Task ProvideFoood()
        {
            Console.WriteLine("The Food is distribution is started");
            await Task.Delay(2000);
            return;
        }





    }
}
