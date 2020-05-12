using Bank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bank.DAL
{
    public class BankInitializer : DropCreateDatabaseIfModelChanges<BankContext>
    {
        protected override void Seed(BankContext context)
        {


            var addresses = new List<Address>
            {
                new Address {HouseNumber = "8A", Street = "Warszawska", City = "Siedlce",  PostCode = "02-312"},
                new Address {HouseNumber = "3", Street = "Dobra", City = "Warszawa",  PostCode = "04-322"},
                new Address {HouseNumber = "51C", Street = "Fajna", City = "Siedlce",  PostCode = "03-112"}
            };

            addresses.ForEach(a => context.Addresses.Add(a));
            context.SaveChanges();

            var bankAccounts = new List<BankAccount>
            {
                new BankAccount {Number = "1" , Balance = 0},
                new BankAccount {Number = "2" , Balance = 0},
                new BankAccount {Number = "3" , Balance = 0}
            };

            bankAccounts.ForEach(b => context.BankAccounts.Add(b));
            context.SaveChanges();

            var profiles = new List<Profile>
            {
                new Profile { Address = addresses[0], BankAccount = bankAccounts[0], Name = "Marcin", LastName = "Fajny", Email = "jakis@wp.pl", BirthDate = DateTime.Parse("1998-01-03"), MothersName = "Magda", Pesel = "12312312312"},
                new Profile { Address = addresses[1], BankAccount = bankAccounts[1], Name = "Paweł", LastName = "Kowalski", Email = "jakis1@wp.pl", BirthDate = DateTime.Parse("1999-02-03"), MothersName = "Aleksandra", Pesel = "12312312313"},
                new Profile { Address = addresses[2], BankAccount = bankAccounts[2], Name = "Adam", LastName = "Dobry", Email = "jakis2@wp.pl", BirthDate = DateTime.Parse("2000-05-03"), MothersName = "Marysia", Pesel = "12312312314"},
            };

            profiles.ForEach(p => context.Profiles.Add(p));
            context.SaveChanges();

            var transferTypes = new List<TransferType>
            {
                new TransferType {Name = "Transfer"},
                new TransferType {Name = "Payment"},
                new TransferType {Name = "PayOff"},
            };

            transferTypes.ForEach(tp => context.TransferTypes.Add(tp));
            context.SaveChanges();

            var Transfers = new List<Transfer>
            {
                new Transfer { TransferType = transferTypes[0], AddressesNumber = "1", ReciversNumber = "2"},
                new Transfer { TransferType = transferTypes[1], AddressesNumber = "2", ReciversNumber = "1"},
                new Transfer { TransferType = transferTypes[2], AddressesNumber = "3", ReciversNumber = "1"}
            };

            Transfers.ForEach(n => context.Transfers.Add(n));
            context.SaveChanges();

            var notifications = new List<Notification>
            {
                new Notification { Profile = profiles[0], Message = "New Transfer", Date = DateTime.Parse("2020-05-03")},
                new Notification { Profile = profiles[1], Message = "New Transfer", Date = DateTime.Parse("2020-05-03")},
                new Notification { Profile = profiles[2], Message = "New Transfer", Date = DateTime.Parse("2020-05-03")},
            };

            notifications.ForEach(n => context.Notifications.Add(n));
            context.SaveChanges();


        }
    }
}