using ContactManagerLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContactManagerLibrary.Services
{
    internal class Alerts : IAlerts
    {
        int lowestSla;
        int unactionedCorrespondence;
        int activeComplaintCount;
        int complaintHistoryCount;
        bool verified;


    }
}
