
using System;
using V82;
using V82.������������;//������;
namespace V82.������������//������
{
		///<summary>
		///��� ��������� �� ���������� �� ������� ��� 0%
		///</summary>
	public enum ����������������������0
	{
		������������ = - 1,
	///<summary>
	///��������� ������������� 0%
	///</summary>
		���������������������� = 0,//��������� ������������� 0%
	///<summary>
	///������������ ���������� 0%
	///</summary>
		����������������������0 = 1,//������������ ���������� 0%
	///<summary>
	///�� ������������ ���������� 0%
	///</summary>
		������������������������0 = 2,//�� ������������ ���������� 0%
	}
	public static partial class ����������������������0_��������//:������������������
	{
		///<summary>
		///��������� ������������� 0%
		///</summary>
		public static readonly Guid ���������������������� = new Guid("38446b9d-21df-ccc6-4d41-71f25b9a29c0");//��������� ������������� 0%
		///<summary>
		///������������ ���������� 0%
		///</summary>
		public static readonly Guid ����������������������0 = new Guid("1219f797-c3bb-decd-4546-15ff8c6ca452");//������������ ���������� 0%
		///<summary>
		///�� ������������ ���������� 0%
		///</summary>
		public static readonly Guid ������������������������0 = new Guid("bd30b2b6-1a5b-f985-409a-93a9646273e2");//�� ������������ ���������� 0%
		public static ����������������������0 ��������(this ����������������������0 ��������, byte[] ������)
		{
			return ��������(��������, new Guid(������));
		}
		public static ����������������������0 ��������(this ����������������������0 ��������, Guid ������)
		{
			if(������ == ����������������������)
			{
				return ����������������������0.����������������������;
			}
			else if(������ == ����������������������0)
			{
				return ����������������������0.����������������������0;
			}
			else if(������ == ������������������������0)
			{
				return ����������������������0.������������������������0;
			}
			return ����������������������0.������������;
		}
		public static byte[] ����(this ����������������������0 ��������)
		{
			return ������(��������).ToByteArray();
		}
		public static Guid ������(this ����������������������0 ��������)
		{
			switch (��������)
			{
				case ����������������������0.����������������������: return ����������������������;
				case ����������������������0.����������������������0: return ����������������������0;
				case ����������������������0.������������������������0: return ������������������������0;
			}
			return Guid.Empty;
		}
	}
}
