
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ���������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		���1 = 0,//1
	///<summary>
	///(���)
	///</summary>
		���1000 = 1,//1 000
	///<summary>
	///(���)
	///</summary>
		���1000000 = 2,//1 000 000
	}
	public static partial class ���������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���1 = new Guid("7041af92-8431-6647-46f6-060d294ed411");//1
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���1000 = new Guid("c6520191-0cb5-7d95-43b2-84d07e85a6d7");//1 000
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���1000000 = new Guid("36fb6cb7-976e-e952-4804-06fd9d574fc0");//1 000 000
		public static ��������������������������� ��������(this ��������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������� ��������(this ��������������������������� ��������, Guid ������)
		{
			if(������ == ���1)
			{
				return ���������������������������.���1;
			}
			else if(������ == ���1000)
			{
				return ���������������������������.���1000;
			}
			else if(������ == ���1000000)
			{
				return ���������������������������.���1000000;
			}
			return ���������������������������.������������;
		}
		public static byte[] ����(this ��������������������������� ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ��������������������������� ��������)
		{
			switch (��������)
			{
				case ���������������������������.���1: return ���1;
				case ���������������������������.���1000: return ���1000;
				case ���������������������������.���1000000: return ���1000000;
			}
			return Guid.Empty;
		}
	}
}
