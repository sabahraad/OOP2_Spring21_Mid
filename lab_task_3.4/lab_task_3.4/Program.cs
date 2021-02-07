using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_3
{
	class Student
	{

	private String name;
	private String id;
	private String department;
	private float cgpa;

	public Student()

	{
		 name="Sabah Raad";
	     id="18-38242-2";
	     department="CS";
	     cgpa=3.61f;
    }
	public Student(string name, string id,string department,float cgpa)
	
	{
		this.name = name;
		this.id = id;
		this.department = department;
	    this.cgpa = cgpa;
	}
	public void setInfo(string name, string id, string department, float cgpa)
		{

		this.name = name;
		this.id = id;
		this.department = department;
		this.cgpa = cgpa;
	    }

		public void ShowInfo()
		{
			Console.WriteLine("Name: " + name);
			Console.WriteLine(" ID: " + id);
			Console.WriteLine("DEPARTMENT : " + department);
			Console.WriteLine("CGPA: " + cgpa);
		}

	}
	class Triangle
	{
		private int x;
		private int y;
		private int z;

		public Triangle()
		{
			int x = 40;
			int y = 20;
			int z = 20;

        }
		public Triangle(int x,int y,int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;

		}
		public void Setinfo(int x,int y,int z)
        {
			this.x = x;
			this.y = y;
			this.z = z;
        }
		public void ShowInfo()
        {
			Console.WriteLine("1st Side: " + x);
			Console.WriteLine("2nd Side: " + y);
			Console.WriteLine("3rd Side: " + z);
			
		}
		public void TestTriangle()
        {
			if (x== y&& y== z)
			{
				Console.Write("This is an equilateral triangle.\n");
			}
			else if (x== y|| x== z|| y== z)
			{
				Console.Write("This is an isosceles triangle.\n");
			}
			else
			{
				Console.Write("This is a scalene triangle.\n");
			}
		}

	}
	class Account
	{
		private String accName;
		private String acid;
		private int balance;
		int amount = 500;

		public Account()
		{
			accName = "RAAD";
			acid = "189";
			balance = 500;
		}
		public Account(String accName,String acid,int balance)
        {
			this.accName = accName;
			this.acid = acid;
			this.balance = balance;
        }
		public void SetInfo(String accName,String acid, int balance)
		{
			this.accName = accName;
			this.acid = acid;
			this.balance = balance;
		}
		public double doDeposit()
		{
			balance += amount;
			return balance;
			
		}

		public double doWithdrawl()
		{
			balance -= amount;

			if (balance < 0)
			{
				Console.WriteLine(" zero balance");
			}
			return balance;
		}
		public void ShowInfo()
        {
			Console.WriteLine("New balance" + balance);
        }


	}
	class Course
    {
		private String coursename;
		private String coursecode;
		private int coursecredit;

		public Course()
        {
			coursename = "kj";
			coursecode = "102";
			coursecredit = 3;
        }
		public Course(String coursename,String coursecode,int coursecredit)
        {
			this.coursename = coursename;
			this.coursecode = coursecode;
			this.coursecredit = coursecredit;
        }
		public void SetInfo(String coursename, String coursecode, int coursecredit)
		{
			this.coursename = coursename;
			this.coursecode = coursecode;
			this.coursecredit = coursecredit;
		}
		public void ShowInfo()
        {
			Console.WriteLine("Course Name:" + coursename);
			Console.WriteLine("Course credit " + coursecredit);
			Console.WriteLine("Course code" + coursecode);
		}
	}

	class Program
	{
		static void Main()
		{
			Student S1 = new Student();
			S1.ShowInfo();
			Triangle T1 = new Triangle();
			T1.TestTriangle();
			Account A1 = new Account();
			A1.doDeposit();
			A1.doWithdrawl();
			A1.ShowInfo();
			Course C1 = new Course();
			C1.ShowInfo();


		}
	}
}