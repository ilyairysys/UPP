
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
	///��������� ������������ ���������� ������������� �������
	///</summary>
	public partial class ���������������������������������������������������:����������������
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
		public string/*100*/ ������������;
		public DateTime ����������������;//������� ���������
		public V82.������������/*������*/.������������� �����������������;//������ �����������
		public V82.�����������������.����������� �����������;
		public V82.������������/*������*/.�������������������������� �����������������;//������ ����� ������
		public V82.�����������������.������������������������ ������������������������;//������������� �����������
		public bool ���������������������������������;//����������� ��������� �������������
		///<summary>
		///���������� ������������� ������������� �������
		///</summary>
		public string/*(36)*/ �������������������;//������������ �������
		public bool ��������������������������;//�� ������������ ��� ���������
		public string/*(0)*/ �����������;
		///<summary>
		///���������� ���� ����� ��������� �������, �� ��������� ������� ����������� ���������
		///</summary>
		public decimal/*(2)*/ ��������;
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
						Insert Into _Reference159(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld2871
						,_Fld2872RRef
						,_Fld2873RRef
						,_Fld2874RRef
						,_Fld2875RRef
						,_Fld2876
						,_Fld2877
						,_Fld2878
						,_Fld2879
						,_Fld2880)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@��������
						,@���������
						,@������������
						,@����������������
						,@�����������������
						,@�����������
						,@�����������������
						,@������������������������
						,@���������������������������������
						,@�������������������
						,@��������������������������
						,@�����������
						,@��������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference159
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_ParentIDRRef	= @��������
						,_Folder	= @���������
						,_Description	= @������������
						,_Fld2871	= @����������������
						,_Fld2872RRef	= @�����������������
						,_Fld2873RRef	= @�����������
						,_Fld2874RRef	= @�����������������
						,_Fld2875RRef	= @������������������������
						,_Fld2876	= @���������������������������������
						,_Fld2877	= @�������������������
						,_Fld2878	= @��������������������������
						,_Fld2879	= @�����������
						,_Fld2880	= @��������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("��������", ��������);
					�������.Parameters.AddWithValue("���������", ���������?new byte[]{0}:new byte[]{1});
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("�����������������", �����������������.����());
					�������.Parameters.AddWithValue("�����������", �����������.������);
					�������.Parameters.AddWithValue("�����������������", �����������������.����());
					�������.Parameters.AddWithValue("������������������������", ������������������������.������);
					�������.Parameters.AddWithValue("���������������������������������", ���������������������������������);
					�������.Parameters.AddWithValue("�������������������", �������������������);
					�������.Parameters.AddWithValue("��������������������������", ��������������������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("��������", ��������);
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
					�������.CommandText = @"Delete _Reference159
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		////////////////////////////////////////////////////////////////////////////////
		// ����� ��������� � �������
		// ��������� �������� ������������� ����������.
		//
		// ���������
		//	��������� - ��������� ��������� �� ������
		//
		// ������������ ��������
		//	������  - ��� ����������� ��������� ���������
		//	����	- �� ��� ����������� ��������� ���������

		public object ������������������(/*���� ���������*/)
		{
			if(true/*���������*/)
			{
			}
			/*����� = ����;*/
			/*// ������ ���� ��������� ������������ ���������
*/
			/*�������������������������� = ����� ���������();*/
			/*��������������������������.��������("�����������������",	   "�� ������ ������ ����������� ����������� ����������");*/
			/*��������������������.���������������������������������(����������, ��������������������������, �����, ���������);*/
		}
		// �������������� ��������� ��������� �� ������� ��� ������
		//
		// ������������ ��������
		//  ������, ��������� ���������

		public object ������������������(/**/)
		{
		}
		// ���������� ��� ������� ���������� ��� �������� ����. �������
		//
		// ������������ ��������
		//	������  - ��� ������� ����������

		public object �����������������������(/**/)
		{
		}
	}
}
