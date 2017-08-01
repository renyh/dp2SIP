﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalPlatform.SIP2.Response
{
    /*
    Checkout Response
    This message must be sent by the ACS in response to a Checkout message from the SC.
    12<ok><renewal ok><magnetic media><desensitize><transaction date><institution id><patron identifier><item identifier><title identifier><due date><fee type><security inhibit><currency type><fee amount><media type><item properties><transaction id><screen message><print line>
    12	1-char	1-char	1-char	1-char	18-char	AO	AA	AB	AJ	AH BT	CI	BH	BV	CK	CH	BK	AF	AG
     */
    public class CheckoutResponse_12 : BaseMessage
    {
        public CheckoutResponse_12()
        {
            this.CommandIdentifier = "12";

            //==前面的定长字段
            //<ok><renewal ok><magnetic media><desensitize><transaction date>
            //1-char	1-char	1-char	1-char	18-char
            this.FixedLengthFields.Add(new FixedLengthField(SIPConst.F_Ok, 1));
            this.FixedLengthFields.Add(new FixedLengthField(SIPConst.F_RenewalOk, 1));
            this.FixedLengthFields.Add(new FixedLengthField(SIPConst.F_MagneticMedia, 1));
            this.FixedLengthFields.Add(new FixedLengthField(SIPConst.F_Desensitize, 1));
            this.FixedLengthFields.Add(new FixedLengthField(SIPConst.F_TransactionDate, 18));

            //==后面变长字段
            //<institution id><patron identifier><item identifier><title identifier><due date><fee type><security inhibit><currency type><fee amount><media type><item properties><transaction id><screen message><print line>
            //	AO	AA	AB	---AJ	    AH  BT	---CI	BH	BV	---CK	CH	BK	AF	AG
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AO_InstitutionId, true));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AA_PatronIdentifier, true));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AB_ItemIdentifier, true));

            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AJ_TitleIdentifier, true));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AH_DueDate, true));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_BT_FeeType, false ));

            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_CI_SecurityInhibit, false ));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_BH_CurrencyType, false ));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_BV_FeeAmount, false ));

            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_CK_MediaType, false ));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_CH_ItemProperties, false ));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_BK_TransactionId, false ));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AF_ScreenMessage, false ));
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AG_PrintLine, false ));

            // 校验码相关，todo
            this.VariableLengthFields.Add(new VariableLengthField(SIPConst.F_AY_SequenceNumber, false));

        }

        /*
        //OK should be set to 1 if the ACS checked out the item to the patron. should be set to 0 if the ACS did not check out the item to the patron.
        //1-char, fixed-length required field:  0 or 1.
        public string Ok_1{ get; set; }

        //Renewal OK should be set to Y if the patron requesting to check out the item already has the item checked out should be set to N if the item is not already checked out to the requesting patron. 
        //1-char, fixed-length required field:  Y or N.
        public string RenewalOk_1{ get; set; }

        //1-char, fixed-length required field:  Y or N or U.
        public string MagneticMedia_1{ get; set; }

        // Desensitize should be set to Y if the SC should desensitize the article. should be set to N if the SC should not desensitize the article (for example, a closed reserve book, or the checkout was refused).
        //1-char, fixed-length required field:  Y or N or U.
        public string Desensitize_1{ get; set; }

        //18-char, fixed-length required field:  YYYYMMDDZZZZHHMMSS
        public string TransactionDate_18{ get; set; }

        //variable-length required field
        public string InstitutionId_AO_r{ get; set; }

        //variable-length required field
        public string PatronIdentifier_AA_r{ get; set; }

        //variable-length required field
        public string ItemIdentifier_AB_r{ get; set; }

        //variable-length required field
        public string TitleIdentifier_AJ_r{ get; set; }

        //variable-length required field
        public string DueDate_AH_r{ get; set; }

        //2-char, fixed-length optional field (01 thru 99).  The type of fee associated with checking out this item.
        public string FeeType_BT_2_o{ get; set; }

        //1-char, fixed-length optional field:  Y or N.
        public string SecurityInhibit_CI_1_o{ get; set; }

        //3-char fixed-length optional field
        public string CurrencyType_BH_3_o{ get; set; }

        //Fee Amount should be set to the value of the fee associated with checking out the item should be set to 0 if there is no fee associated with checking out the item.
        //variable-length optional field.  The amount of the fee associated with checking out this item.
        public string FeeAmount_BV_o{ get; set; }

        //3-char, fixed-length optional field
        public string MediaType_CK_3_o{ get; set; }

        //variable-length optional field
        public string ItemProperties_CH_o{ get; set; }

        //variable-length optional field.  May be assigned by the ACS when checking out the item involves a fee.
        public string TransactionId_BK_o{ get; set; }

        //variable-length optional field
        public string ScreenMessage_AF_o{ get; set; }

        //variable-length optional field
        public string PrintLine_AG_o{ get; set; }
        */
    }
}
