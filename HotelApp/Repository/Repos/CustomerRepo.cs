using HotelApp.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Repository.Repos
{
    public class CustomerRepo
    {
        HotelDbContext _context = new();

        public void UpdateCustomer(Customer newVersionOfCustomer)
        {
            var oldCustomer = _context.Customers.Find(newVersionOfCustomer.CustomerId);

            _context.Entry(oldCustomer).CurrentValues.SetValues(newVersionOfCustomer);

            _context.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            bool doesCustomerHaveABooking = _context.Bookings.Any(b => b.Customer.CustomerId == customer.CustomerId);

            if (doesCustomerHaveABooking)
            {
                MessageBox.Show("You can not delete a customer that have a booking.");
            }
            else
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();

                MessageBox.Show("Customer have been deleted.");
            }
        }

        public List<Customer> Search(string query)
        {
            var searchResult = _context.Customers.Where(c => c.FullName.Contains(query))
                                                      .AsNoTracking().ToList();
            return searchResult;
        }
    }
}
