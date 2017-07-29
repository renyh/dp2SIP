﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalPlatform.SIP2.Request
{
    /*
2.00 End Patron Session
This message will be sent when a patron has completed all of their transactions.  The ACS may, upon receipt of this command, close any open files or deallocate data structures pertaining to that patron. The ACS should respond with an End Session Response message.
35<transaction date><institution id><patron identifier><terminal password><patron password>
 */
    public class EndPatronSession_35 : BaseMessage
    {
        //18-char, fixed-length required field:  YYYYMMDDZZZZHHMMSS
        public string TransactionDate_18{ get; set; }

        // variable-length required field
        public string InstitutionId_AO_r{ get; set; }

        // variable-length required field.
        public string PatronIdentifier_AA_r{ get; set; }

        // variable-length optional field
        public string TerminalPassword_AC_o{ get; set; }

        // variable-length optional field
        public string PatronPassword_AD_o{ get; set; }

    }
}