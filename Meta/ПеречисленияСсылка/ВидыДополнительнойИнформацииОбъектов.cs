
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///(���)
		///</summary>
	public enum ������������������������������������
	{
		������������ = - 1,
	///<summary>
	///(���)
	///</summary>
		���� = 0,
	///<summary>
	///(���)
	///</summary>
		����������� = 1,
	}
	public static partial class ������������������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���� = new Guid("31557a81-f93c-9506-4017-6ec265d1230b");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ����������� = new Guid("7e647ca6-d271-40e9-4898-e8175b9be8fd");
		public static ������������������������������������ ��������(this ������������������������������������ ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ������������������������������������ ��������(this ������������������������������������ ��������, Guid ������)
		{
			if(������ == ����)
			{
				return ������������������������������������.����;
			}
			else if(������ == �����������)
			{
				return ������������������������������������.�����������;
			}
			return ������������������������������������.������������;
		}
		public static byte[] ����(this ������������������������������������ ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ������������������������������������ ��������)
		{
			switch (��������)
			{
				case ������������������������������������.����: return ����;
				case ������������������������������������.�����������: return �����������;
			}
			return Guid.Empty;
		}
	}
}
