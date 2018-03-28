using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Lab_1._4
{
    class MailUser {
        public string From { get; set; } 
        public string MailTo { get; set; }
        public string Caption { get; set; }
        public string Message { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        public static void Send(Action send)
        {
            send();
            Console.WriteLine("The message has been successfully sent");
        }
        public static bool Validation(string[] args) {
            
                if (String.IsNullOrEmpty(args[0]) && String.IsNullOrEmpty(args[1]))
                {
                    Console.WriteLine("The one of arguments is null of empty");
                    return false;
                }
                return true;
        }
        static void Main(string[] args)
        {
            try
            {
                
                bool access = Validation(args);
                if (access)
                {
                    MailUser mailUser = new MailUser();
                    mailUser.From = "Skalpel52@gmail.com";
                    mailUser.Caption = "";
                    mailUser.Message = DateTime.Now.ToString() + " Nikita Galchenko";
                    mailUser.MailTo = "";
                    mailUser.Email = "";//email
                    mailUser.Password = "";//password

                    string input = "";

                    
                    string[] MailAndText = input.Split(' ');

                    while ((MailAndText.Length != 2))
                    {
                        Console.WriteLine("Enter e-mail and caption with space between");
                        input = Console.ReadLine();
                        MailAndText = input.Split(' ');
                    }

                    mailUser.MailTo = MailAndText[0];
                    mailUser.Caption = MailAndText[1];

                    Send( () =>
                    {
                        NetworkCredential loginInfo = new NetworkCredential(mailUser.Email, mailUser.Password);
                        MailMessage msg = new MailMessage();
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                        msg.From = new MailAddress(mailUser.From);
                        msg.To.Add(new MailAddress(mailUser.MailTo));
                        msg.Subject = mailUser.Caption;
                        msg.Body = mailUser.Message;

                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = loginInfo;
                        smtpClient.Send(msg);
                    } );
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
           
            
        }
    }
}