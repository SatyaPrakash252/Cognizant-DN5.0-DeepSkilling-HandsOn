using System;


namespace UserManagerLib
{


    public class UserManager
    {


        public string CreateUser(User user)
        {



            if (
                string.IsNullOrEmpty(
                    user.PANCardNo
                )
              )
            {


                throw new NullReferenceException();


            }





            if (
                user.PANCardNo.Length != 10
              )
            {


                throw new FormatException();


            }




            return "User Created Successfully";



        }


    }


}