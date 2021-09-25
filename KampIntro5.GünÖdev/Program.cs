using System;

namespace KampIntro5.GünÖdev
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            {
            Id=1,
            BirthYear=1985,
            FirstName="engin",
            Lastname="demiroğ",
            IdentityNumber=12345            
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Hosgeldin(new CampaignManager
            {
            });

            GameManager gameManager = new GameManager();
            gameManager.Oyunsatinalindi(new GameManager
            {
               
            });
         

        }
    }
}
