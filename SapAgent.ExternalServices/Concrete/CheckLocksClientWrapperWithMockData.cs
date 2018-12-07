﻿using CheckLocks;
using SapAgent.ExternalServices.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapAgent.ExternalServices.Concrete
{
    public class CheckLocksClientWrapperWithMockData : ICheckLocksClientWrapper
    {
        private zaygbcsys_ws_chklocks _userSessionClient;

        public CheckLocksClientWrapperWithMockData(zaygbcsys_ws_chklocks userSessionClient)
        {
            _userSessionClient = userSessionClient;
        }
        public async Task<ZaygbcsysLocksRf[]> GetData()
        {
            return new ZaygbcsysRfcsLocksResponse1
            {
                ZaygbcsysRfcsLocksResponse = new ZaygbcsysRfcsLocksResponse
                {
                    EtLockList = new[] {
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPR2.......................",
                          Guname="JOBMM",
                          Gdsptime="21.10.2018",
                          Gmode="E",
                          Gname="EKKO",
                          Garg="4003100130497",
                          Gusr="",
                          Gusrvb="20181021154640630094006900AYGERPPR2.......................",
                          Guse=0,
                          Gusevb=1,
                          Gobj="EMEKKOE",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="X",
                          LockDuration=333693
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPR2.......................",
                          Guname="JOBMM",
                          Gdsptime="21.10.2018",
                          Gmode="E",
                          Gname="EKPO",
                          Garg="4003100130497",
                          Gusr="",
                          Gusrvb="20181021154640630094006900AYGERPPR2.......................",
                          Guse=0,
                          Gusevb=1,
                          Gobj="EMEKKOE",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="X",
                          LockDuration=333693
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPR2.......................",
                          Guname="JOBMM",
                          Gdsptime="21.10.2018",
                          Gmode="E",
                          Gname="EKKO",
                          Garg="4003100130536",
                          Gusr="",
                          Gusrvb="20181021154643632625006900AYGERPPR2.......................",
                          Guse=0,
                          Gusevb=1,
                          Gobj="EMEKKOE",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="X",
                          LockDuration=333690
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPR2.......................",
                          Guname="JOBMM",
                          Gdsptime="21.10.2018",
                          Gmode="E",
                          Gname="EKPO",
                          Garg="4003100130536",
                          Gusr="",
                          Gusrvb="20181021154643632625006900AYGERPPR2.......................",
                          Guse=0,
                          Gusevb=1,
                          Gobj="EMEKKOE",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="X",
                          LockDuration=333690
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPRD.......................",
                          Guname="10807274",
                          Gdsptime="08:22:23",
                          Gmode="E",
                          Gname="/PCIS05/PLADRH",
                          Garg="400002000312254",
                          Gusr="20181025082223279828000300AYGERPPRD.......................",
                          Gusrvb="",
                          Guse=1,
                          Gusevb=0,
                          Gobj="/PCIS05/EREQUEST",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="",
                          LockDuration=14750
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPRD.......................",
                          Guname="10807274",
                          Gdsptime="08:33:19",
                          Gmode="E",
                          Gname="/PCIS05/PLADRH",
                          Garg="400004100166172",
                          Gusr="20181025083319561123000500AYGERPPRD.......................",
                          Gusrvb="",
                          Guse=1,
                          Gusevb=0,
                          Gobj="/PCIS05/EREQUEST",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="",
                          LockDuration=14094
                      },new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPAPP1......................",
                          Guname="10805076",
                          Gdsptime="09:09:44",
                          Gmode="E",
                          Gname="/PCIS05/PLADRH",
                          Garg="400001000966922",
                          Gusr="20181025090944941775002700AYGERPAPP1......................",
                          Gusrvb="",
                          Guse=1,
                          Gusevb=0,
                          Gobj="/PCIS05/EREQUEST",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="",
                          LockDuration=11909
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPAPP1......................",
                          Guname="10805076",
                          Gdsptime="09:09:52",
                          Gmode="",
                          Gname="/PCIS05/PLADRH",
                          Garg="400001000966923",
                          Gusr="20181025090952916974002700AYGERPAPP1......................",
                          Gusrvb="",
                          Guse=1,
                          Gusevb=0,
                          Gobj="/PCIS05/EREQUEST",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="",
                          LockDuration=11901
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPRD.......................",
                          Guname="10807274",
                          Gdsptime="09:58:52",
                          Gmode="E",
                          Gname="/PCIS05/PLADRH",
                          Garg="400001000966910",
                          Gusr="20181025095852795800002800AYGERPPRD.......................",
                          Gusrvb="",
                          Guse=1,
                          Gusevb=0,
                          Gobj="/PCIS05/EREQUEST",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="",
                          LockDuration=8961
                      },
                      new ZaygbcsysLocksRf{
                          Gclient="400",
                          Gthost="AYGERPPR2.......................",
                          Guname="7900133",
                          Gdsptime="11:52:22",
                          Gmode="E",
                          Gname="TCJ_C_JOURNALS",
                          Garg="4021078TL17",
                          Gusr="20181025115222512828003900AYGERPPR2.......................",
                          Gusrvb="",
                          Guse=1,
                          Gusevb=0,
                          Gobj="EFBCJ_LOCK",
                          GsourceType="",
                          GsourceId="",
                          GsourceComponent="",
                          Gtdate="21.10.2018",
                          Gttime=new DateTime(),
                          Backed="",
                          LockDuration=2151
                      },
                  }
                }
            }.ZaygbcsysRfcsLocksResponse.EtLockList;
        }
    }
}
