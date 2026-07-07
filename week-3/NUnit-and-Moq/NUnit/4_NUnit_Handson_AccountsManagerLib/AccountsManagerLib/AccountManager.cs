using System;


namespace AccountsManagerLib
{

    public class AccountManager
    {


        public string Login(
            string userId,
            string password
        )
        {


            if (
                string.IsNullOrEmpty(userId)
                ||
                string.IsNullOrEmpty(password)
              )
            {
                throw new ArgumentException();
            }




            if (
                userId == "user_11"
                &&
                password == "secret@user11"
              )
            {

                return
                $"Welcome {userId}!!!";

            }



            if (
                userId == "user_22"
                &&
                password == "secret@user22"
              )
            {

                return
                $"Welcome {userId}!!!";

            }




            return
            "Invalid user id/password";


        }



    }

}