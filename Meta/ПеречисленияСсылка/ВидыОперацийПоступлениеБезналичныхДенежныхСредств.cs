
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum �������������������������������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		���������������� = 0,//������ �� ����������
	///<summary>
	///(���)
	///</summary>
		��������������������������������� = 1,//������� �������� ������� �����������
		������������������������ = 2,//������� �� �������� � ������
		��������������������������� = 3,//������ ������� � �������������
		����������������������������� = 4,//������������ ����������� ������
		������������������������������������� = 5,//����������� �� ������� ����������� ������
		������������������������������������������� = 6,//������ ����������� ����������� �������� �������
		���������������������������������� = 7,//����������� ������ �� ��������� ������
		������������������������������������� = 8,//����������� ������ �� ���������� ��������
	}
	public static partial class �������������������������������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������������� = new Guid("c3182d9a-8e34-671d-496e-966d8e337b09");//������ �� ����������
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ��������������������������������� = new Guid("7927978b-1b69-594b-4e16-a0ba6d7ed27b");//������� �������� ������� �����������
		public static readonly Guid ������������������������ = new Guid("7167b98e-dce5-25a8-4799-6039148de074");//������� �� �������� � ������
		public static readonly Guid ��������������������������� = new Guid("e13ec8a3-2b6a-9e7d-4c80-1f71a81317cc");//������ ������� � �������������
		public static readonly Guid ����������������������������� = new Guid("f9dbc4ba-4490-bdc2-4085-4fe72f27de4c");//������������ ����������� ������
		public static readonly Guid ������������������������������������� = new Guid("f81d14ae-0925-f9fd-4005-363063af9a15");//����������� �� ������� ����������� ������
		public static readonly Guid ������������������������������������������� = new Guid("3555259e-e018-fbae-41d8-1c3f8dc02185");//������ ����������� ����������� �������� �������
		public static readonly Guid ���������������������������������� = new Guid("7b315baf-e4e1-0e3f-4fb3-b74486a29209");//����������� ������ �� ��������� ������
		public static readonly Guid ������������������������������������� = new Guid("29dfe9b2-0abb-ab49-4913-11f4dd14c074");//����������� ������ �� ���������� ��������
		public static ������������������������������������������������� ��������(this ������������������������������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������������������������� ��������(this ������������������������������������������������� ��������, Guid ������)
		{
			if(������ == ����������������)
			{
				return �������������������������������������������������.����������������;
			}
			else if(������ == ���������������������������������)
			{
				return �������������������������������������������������.���������������������������������;
			}
			else if(������ == ������������������������)
			{
				return �������������������������������������������������.������������������������;
			}
			else if(������ == ���������������������������)
			{
				return �������������������������������������������������.���������������������������;
			}
			else if(������ == �����������������������������)
			{
				return �������������������������������������������������.�����������������������������;
			}
			else if(������ == �������������������������������������)
			{
				return �������������������������������������������������.�������������������������������������;
			}
			else if(������ == �������������������������������������������)
			{
				return �������������������������������������������������.�������������������������������������������;
			}
			else if(������ == ����������������������������������)
			{
				return �������������������������������������������������.����������������������������������;
			}
			else if(������ == �������������������������������������)
			{
				return �������������������������������������������������.�������������������������������������;
			}
			return �������������������������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������������������������� ��������)
		{
			switch (��������)
			{
				case �������������������������������������������������.����������������: return ����������������;
				case �������������������������������������������������.���������������������������������: return ���������������������������������;
				case �������������������������������������������������.������������������������: return ������������������������;
				case �������������������������������������������������.���������������������������: return ���������������������������;
				case �������������������������������������������������.�����������������������������: return �����������������������������;
				case �������������������������������������������������.�������������������������������������: return �������������������������������������;
				case �������������������������������������������������.�������������������������������������������: return �������������������������������������������;
				case �������������������������������������������������.����������������������������������: return ����������������������������������;
				case �������������������������������������������������.�������������������������������������: return �������������������������������������;
			}
			return Guid.Empty;
		}
	}
}
