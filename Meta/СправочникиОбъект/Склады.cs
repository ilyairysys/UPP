
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������������
{
	///<summary>
	///(���)
	///</summary>
	public partial class ������:����������������
	{
		public bool _��������;
		public bool ��������()
		{
			return _��������;
		}
		public Guid ������;
		public long ������;
		/*static ��� ����� ������� � ������� ����������*/
		/*������ ������ ���������������� �� ������*/
		public bool ���������������;
		public bool ����������������;
		public Guid ��������;
		public bool ���������;
		public Guid ��������;
		public string/*9*/ ���;
		public string/*50*/ ������������;
		///<summary>
		///(���) ����� �������������� ����������
		///</summary>
		public string/*(0)*/ �����������;
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.������������������� �����������������������;//��� ��� ��������� ��������
		///<summary>
		///(���)
		///</summary>
		public V82.�����������������.������������� �������������;
		///<summary>
		///(���)
		///</summary>
		public V82.������������/*������*/.����������� ���������;//��� ������
		///<summary>
		///(���)
		///</summary>
		public decimal/*(1)*/ �����������;//����� ������
		public bool �����������������������������������;//������ ��������� ��� �� �������� �������
		public void ��������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					if(_��������)
					{
						�������.CommandText = @"
						Insert Into _Reference229(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3427
						,_Fld3428RRef
						,_Fld3429RRef
						,_Fld3430RRef
						,_Fld3431
						,_Fld3432)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@���
						,@������������
						,@�����������
						,@�����������������������
						,@�������������
						,@���������
						,@�����������
						,@�����������������������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference229
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3427	= @�����������
						,_Fld3428RRef	= @�����������������������
						,_Fld3429RRef	= @�������������
						,_Fld3430RRef	= @���������
						,_Fld3431	= @�����������
						,_Fld3432	= @�����������������������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("���������", ���������?new byte[]{0}:new byte[]{1});
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�����������������������", �����������������������.������);
					�������.Parameters.AddWithValue("�������������", �������������.������);
					�������.Parameters.AddWithValue("���������", ���������.����());
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�����������������������������������", �����������������������������������);
					�������.ExecuteNonQuery();
				}
			}
		}
		public void �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Delete _Reference229
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/

		public void ������������(/*�����*/)
		{
			if(true/*�� ������������.��������
	   � �� ���������
	   � �� ��������()
	   � ��������� <> ������.���������
	   � �����������.�����_����������������(������)*/)
			{
				/*����������������.����������������("���������� ���������, � ������� ������ ����� """ + ������������ + """.
		                |�������� ""��� ������"" �� ����� ���� �������, ������� �� �������.");*/
				/*����� = ������;*/
			}
			/*// �� ����� �������� ��������� ����� ��� ��� ��� �������� ���� ���.
*/
			if(true/*�� ������������.��������
	   � �� ���������
	   � (��������� = ������������.�����������.��������� ��� ��������� = ������������.�����������.���)
	   � �� �����������������(�����������������������)*/)
			{
				/*����������������.����������������("��� ������ ���� """+���������+""" ���������� ������� ��� ��� ��������� ��������,
		                 |������� �� �������.");*/
				/*����� = ������;*/
			}
			if(true/*�� ������������.��������*/)
			{
				/*��������������������������������������� = ?(�� ��������() � �� ������.�������� = ��������, ������.��������, ������������);*/
				/*��������������������.�����������������������������������������������������(����������, �����, ��������);*/
			}
		}
		// ������������()
		// ���������� ������� ���������.
		//

		public void ���������(/*�����*/)
		{
			if(true/*�� ������������.��������*/)
			{
				/*��������������������.����������������������������������������������������������(������, ���������������������������������������, �����);*/
			}
		}
		// ���������()
		////////////////////////////////////////////////////////////////////////////////
	}
}
