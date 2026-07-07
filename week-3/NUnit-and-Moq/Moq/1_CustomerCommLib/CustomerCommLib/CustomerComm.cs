namespace CustomerCommLib
{

    public class CustomerComm
    {


        IMailSender mailSender;



        public CustomerComm(
        IMailSender sender)
        {

            mailSender = sender;

        }





        public bool SendMailToCustomer()
        {


            mailSender.SendMail(
                "cust123@abc.com",
                "Some Message"
            );



            return true;


        }


    }

}