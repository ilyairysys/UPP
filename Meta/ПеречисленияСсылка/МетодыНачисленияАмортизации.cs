
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
		�������� = 0,
	///<summary>
	///(���)
	///</summary>
		���������� = 1,
	}
	public static partial class ���������������������������_��������//:������������������
	{
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid �������� = new Guid("54cdb597-c866-3e87-49e0-8e5fe167a445");
		///<summary>
		///(���)
		///</summary>
		public static readonly Guid ���������� = new Guid("aa38b7b1-a929-0825-42bc-ba3584ad0046");
		public static ��������������������������� ��������(this ��������������������������� ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ��������������������������� ��������(this ��������������������������� ��������, Guid ������)
		{
			if(������ == ��������)
			{
				return ���������������������������.��������;
			}
			else if(������ == ����������)
			{
				return ���������������������������.����������;
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
				case ���������������������������.��������: return ��������;
				case ���������������������������.����������: return ����������;
			}
			return Guid.Empty;
		}
	}
}
