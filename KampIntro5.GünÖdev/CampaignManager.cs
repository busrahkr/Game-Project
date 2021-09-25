using System;
using System.Collections.Generic;
using System.Text;

namespace KampIntro5.GünÖdev
{
    public class CampaignManager : ICampaignService
    {
        public void Firsat(CampaignManager campaign)
        {
            Console.WriteLine("%25 İNDİRİM");
        }

        public void Hosgeldin(CampaignManager campaign)
        {
            Console.WriteLine("%40 İNDİRİM");
        }

        public void Yazpaketi(CampaignManager campaign)
        {
            Console.WriteLine("%50 İNDİRİM");
        }
    }
}
