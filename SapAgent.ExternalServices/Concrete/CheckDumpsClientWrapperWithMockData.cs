﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CheckDumps;
using SapAgent.ExternalServices.Abstract;

namespace SapAgent.ExternalServices.Concrete
{
    public class CheckDumpsClientWrapperWithMockData : ICheckDumpsClientWrapper
    {
        private zaygbcsys_ws_chkdumps _checkDumpsClient;

        public CheckDumpsClientWrapperWithMockData(zaygbcsys_ws_chkdumps checkDumpsClient)
        {
            _checkDumpsClient = checkDumpsClient;
        }

        public async Task<Rdumpov[]> GetData()
        {
            return new ZaygbcsysRfcsChkdumpsResponse1
            {
                ZaygbcsysRfcsChkdumpsResponse = new ZaygbcsysRfcsChkdumpsResponse()
                {
                    EtDumplist = new[]
                    {
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPAPP1_AEP_00",
                            Uname = "11220001",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "OBJECTS_OBJREF_NOT_ASSIGNED",
                            Rexception = "CX_SY_REF_IS_INITIAL",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 21,
                            Tid = "31D51C0700060190E005BB4F81A59111"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPR1_AEP_00",
                            Uname = "10807965",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "MESSAGE_TYPE_UNKNOWN",
                            Rexception = "CX_SY_REF_IS_INITIAL",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 4,
                            Tid = "8899B50D73550040E005BB4F8507172C"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPR2_AEP_00",
                            Uname = "10808594",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "TIME_OUT",
                            Rexception = "",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 27,
                            Tid = "7724F573320501B0E005BB4F89FB9991"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPRD_AEP_00",
                            Uname = "10805421",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "GETWA_NOT_ASSIGNED",
                            Rexception = "",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 38,
                            Tid = "DD4E549057110040E005BB4F925036D8"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPR1_AEP_00",
                            Uname = "SOLMAN",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "TIME_OUT",
                            Rexception = "",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 32,
                            Tid = "5BC43DE1100A192AE1000000D40C8042"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPRD_AEP_00",
                            Uname = "10805421",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "GETWA_NOT_ASSIGNED",
                            Rexception = "",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 37,
                            Tid = "DD4E549057110260E005BB4F927BF870"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPAPP1_AEP_00",
                            Uname = "JOBFI",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "SQL_CAUGHT_RABAX",
                            Rexception = "",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 72,
                            Tid = "31D51C0700060480E005BB4F81ECFFCD"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPR1_AEP_00",
                            Uname = "JOBFI",
                            Mandt = "400",
                            Xhold = "C",
                            Errorid = "TSV_TNEW_PAGE_ALLOC_FAILED",
                            Rexception = "",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 72,
                            Tid = "31D51C0700060480E005BB4F81ECFFCD"
                        },
                        new Rdumpov()
                        {
                            Datum = "15.10.2018",
                            Uzeit = new DateTime(),
                            Ahost = "AYGERPPR1_AEP_00",
                            Uname = "JOBFI",
                            Mandt = "406",
                            Xhold = "C",
                            Errorid = "SQL_CAUGHT_RABAX",
                            Rexception = "CX_SY_OPEN_SQL_DB",
                            Component = "Not assigned",
                            Gprogram = "Unknown",
                            Modno = 69,
                            Tid = "8899B50D73550450E005BB5AA8B52B1C"
                        }
                    }
                }
            }.ZaygbcsysRfcsChkdumpsResponse.EtDumplist;
        }
    }
}