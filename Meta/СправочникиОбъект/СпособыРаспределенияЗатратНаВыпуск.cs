
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
	public partial class ����������������������������������:����������������
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
		///(���)
		///</summary>
		public string/*(0)*/ �����������;
		///<summary>
		///(���)
		///</summary>
		public V82.������������/*������*/.���������������������������������� ���������������������������������;//������ ������������� ������ �� ������
		///<summary>
		///(���)
		///</summary>
		public V82.������������/*������*/.������������������������������������������ ����������������������������������������;//��� ������� ��� ������������� ������ �� ������
		public V82.������������/*������*/.����������������������� �����������������������;//���� ������������� ������
		public V82.������������/*������*/.�������������������������������� ���������������������������;//���������� ���� �������������
		public V82.�����������������.������������������� ������;//��� ���
		public V82.�����������������.������������� �������������;//�������� �����
		public V82.�����������������.���������������������������������� �����������������������������������������;//������ ������������� ������ �� ��������������
		public bool ����������������������������������;//������������ �� ����������� ���������
		public bool ����������������������������������������������;//������������ �� ��������� ���������� �������������
		public bool �������������������������������������������;//������������ �� ��������� �� ������������� �����
		public bool ��������������������������������������;//������������ �� ����������� �������������
		public bool �����������������������;//������������ �� ���������
		public decimal/*(5.2)*/ �������;
		public decimal/*(15.3)*/ �����������;
		public V82.������������/*������*/.����������������� �����������������;//������� ����������
		public ����������������� ��������������������;//��������� �����������
		public bool �����������������;//�������� �� �������
		public bool ���������������������;//�������� �� �����������
		public bool �����������;//��������� ��
		public ����������������� ���������������������;//����� ���������� ������
		public V82.������������/*������*/.�������������� ������������;//��� ����� �������� ���������
		///<summary>
		///��� ������������� ���� ���� ������������� ����� ����������� ����������, ���������� �� ������ ���������� ������
		///</summary>
		public bool ��������������������������������;//������������ ���������� �������� ������������� ��������
		public V82.������������/*������*/.������������������������������ ������������������������;//���� ������������
		///<summary>
		///(���)
		///</summary>
		public string/*(0)*/ ��������������;//�������, ������� ����������
		public V82.������������/*������*/.�������������������� ��������������������;//��� ����
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
						Insert Into _Reference244(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3740
						,_Fld3741RRef
						,_Fld3742RRef
						,_Fld3743RRef
						,_Fld3744RRef
						,_Fld3745RRef
						,_Fld3746RRef
						,_Fld3747RRef
						,_Fld3748
						,_Fld3749
						,_Fld3750
						,_Fld3751
						,_Fld3752
						,_Fld3753
						,_Fld3754
						,_Fld3755RRef
						,_Fld3756
						,_Fld3757
						,_Fld3758
						,_Fld3759
						,_Fld3760
						,_Fld3761RRef
						,_Fld3762
						,_Fld3763RRef
						,_Fld3764
						,_Fld3765RRef)
						Values (
						@������
						/*,@������*/
						,@���������������
						,@����������������
						,@���
						,@������������
						,@�����������
						,@���������������������������������
						,@����������������������������������������
						,@�����������������������
						,@���������������������������
						,@������
						,@�������������
						,@�����������������������������������������
						,@����������������������������������
						,@����������������������������������������������
						,@�������������������������������������������
						,@��������������������������������������
						,@�����������������������
						,@�������
						,@�����������
						,@�����������������
						,@��������������������
						,@�����������������
						,@���������������������
						,@�����������
						,@���������������������
						,@������������
						,@��������������������������������
						,@������������������������
						,@��������������
						,@��������������������)";
					}
					else
					{
						�������.CommandText = @"
						Update _Reference244
						Set
						/*_IDRRef	= @������*/
						/*,_Version	= @������*/
						_Marked	= @���������������
						,_IsMetadata	= @����������������
						,_Code	= @���
						,_Description	= @������������
						,_Fld3740	= @�����������
						,_Fld3741RRef	= @���������������������������������
						,_Fld3742RRef	= @����������������������������������������
						,_Fld3743RRef	= @�����������������������
						,_Fld3744RRef	= @���������������������������
						,_Fld3745RRef	= @������
						,_Fld3746RRef	= @�������������
						,_Fld3747RRef	= @�����������������������������������������
						,_Fld3748	= @����������������������������������
						,_Fld3749	= @����������������������������������������������
						,_Fld3750	= @�������������������������������������������
						,_Fld3751	= @��������������������������������������
						,_Fld3752	= @�����������������������
						,_Fld3753	= @�������
						,_Fld3754	= @�����������
						,_Fld3755RRef	= @�����������������
						,_Fld3756	= @��������������������
						,_Fld3757	= @�����������������
						,_Fld3758	= @���������������������
						,_Fld3759	= @�����������
						,_Fld3760	= @���������������������
						,_Fld3761RRef	= @������������
						,_Fld3762	= @��������������������������������
						,_Fld3763RRef	= @������������������������
						,_Fld3764	= @��������������
						,_Fld3765RRef	= @��������������������
						Where _IDRRef = @������";
					}
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					/*�������.Parameters.AddWithValue("������", ������);*/
					�������.Parameters.AddWithValue("���������������", ���������������);
					�������.Parameters.AddWithValue("����������������", ����������������);
					�������.Parameters.AddWithValue("���", ���);
					�������.Parameters.AddWithValue("������������", ������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("���������������������������������", ���������������������������������.����());
					�������.Parameters.AddWithValue("����������������������������������������", ����������������������������������������.����());
					�������.Parameters.AddWithValue("�����������������������", �����������������������.����());
					�������.Parameters.AddWithValue("���������������������������", ���������������������������.����());
					�������.Parameters.AddWithValue("������", ������.������);
					�������.Parameters.AddWithValue("�������������", �������������.������);
					�������.Parameters.AddWithValue("�����������������������������������������", �����������������������������������������.������);
					�������.Parameters.AddWithValue("����������������������������������", ����������������������������������);
					�������.Parameters.AddWithValue("����������������������������������������������", ����������������������������������������������);
					�������.Parameters.AddWithValue("�������������������������������������������", �������������������������������������������);
					�������.Parameters.AddWithValue("��������������������������������������", ��������������������������������������);
					�������.Parameters.AddWithValue("�����������������������", �����������������������);
					�������.Parameters.AddWithValue("�������", �������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("�����������������", �����������������.����());
					�������.Parameters.AddWithValue("�����������������", �����������������);
					�������.Parameters.AddWithValue("���������������������", ���������������������);
					�������.Parameters.AddWithValue("�����������", �����������);
					�������.Parameters.AddWithValue("������������", ������������.����());
					�������.Parameters.AddWithValue("��������������������������������", ��������������������������������);
					�������.Parameters.AddWithValue("������������������������", ������������������������.����());
					�������.Parameters.AddWithValue("��������������", ��������������);
					�������.Parameters.AddWithValue("��������������������", ��������������������.����());
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
					�������.CommandText = @"Delete _Reference244
					Where _IDRRef=@������";
					�������.Parameters.AddWithValue("������", ������.ToByteArray());
					�������.ExecuteNonQuery();
				}
			}
		}
		/*�������������*/
		////////////////////////////////////////////////////////////////////////////////
		// ���������� ��������� � �������
		// ��������� ��������� ��������� ��������� ����������� �������.
		//

		public void ���������������������������(/*�����������������*/)
		{
			/*��������������������������� = ����� ���������;*/
			/*������������ = ����� ������;*/
			/*������������.��������("�������������");*/
			/*������������.��������("������������������������");*/
			if(true/*����������������������� = ������������.�����������������������.���������������
	 ��� ����������������������� = ������������.�����������������������.��������������*/)
			{
				/*����� = " 
		|�������
		|	�������������.������ 					��� �������������
		|{�������
		|	�������������.������.* 					��� �������������,
		|	������������������������.������.* 		��� ������������������������
		|}
		|�� 
		|	����������.������������� 			��� �������������,
		|	����������.������������������������ ��� ������������������������
		|{���
		|	�������������.������.* 					��� �������������,
		|	������������������������.������.* 		��� ������������������������
		|}
		|";*/
			}
			/*// ������������ ���� ����� � ������� � �� ������������� � ������.
*/
			/*��������������������������� = ����� ���������;*/
			/*���������������������������.��������("�������������", 			"�������������");*/
			/*���������������������������.��������("������������������������", "������������� �����������");*/
			if(true/*����������������������� <> ������������.�����������������������.���������������
	   � ����������������������� <> ������������.�����������������������.��������������*/)
			{
				/*���������������������������.��������("���������",        		"��� ������");*/
				/*���������������������������.��������("������������������������","������ ���. ������");*/
				/*���������������������������.��������("��������������", 			"�������� ������");*/
				/*���������������������������.��������("������������", 			"������ ������");*/
			}
			/*�����������������.����� = �����;*/
			/*������������������.���������������������������(���������������������������, �����������������);*/
			/*������������������.�������������������������������������(�����������������);*/
			if(true/*(����������������������� = ������������.�����������������������.���������������
		��� ����������������������� = ������������.�����������������������.��������������)
		� �����������������.�����.����������() > 0*/)
			{
				/*�������������� = �����������������.�����.����������();*/
			}
		}
		// ���������������������������()
		////////////////////////////////////////////////////////////////////////////////
		// ����������� �������
		// ��������� ���������� ������� "��������������"
		//

		public void ��������������(/*�����������������*/)
		{
			if(true/*�����������������.�������������������� = ������������.��������������������.����������������*/)
			{
				/*�������������������� = ������������.��������������������.���;*/
				/*// ��� ���� ���������������� ����������� � ���
*/
			}
		}
		// ��������� ���������� ������� "���������������������������"
		//

		public void ���������������������������(/*�����, ��������������������*/)
		{
			if(true/*������������.��������*/)
			{
			}
			if(true/*����������������������� = ������������.�����������������������.�����������������
	 � ���������������������������������������� = ������������.������������������������������������������.���������*/)
			{
				/*��������� = ����("ru = '������ ������� ������������� �� ������ ""%������������%""'");*/
				/*��������� = �����������(���������, "%������������%", ������������);*/
				/*����������������.����������������(����("ru = '��� ���� ""�� ��������� ������"" ������ ������������ ����������� ������������� ""�� ��������� ���������""'"), �����, ���������,���������������.������, ������);*/
			}
			/*// �������� �� �������� ��������� ��������� ������, �� ������������ ��� ���������� ����������� �������������
*/
			/*�������������� 			  = �����������.����������������������������������.������������������������������������������(����������);*/
			/*������������������������� = ����� ���������(��������������);*/
			/*���������������������� 	  = ����� ������;*/
			/*// ������ ���������, ������� �� ���� ���������, �� ������� ����������� ����������
*/
		}
		// ��������� ���������� ������� "������������"
		//

		public void ������������(/*�����*/)
		{
			if(true/*������������.��������*/)
			{
			}
			/*// ������� �������������� ��������� �����
*/
			/*�������������� 		 = �����������.����������������������������������.������������������������������������������(����������);*/
			/*�������������������� = ����� ���������(��������������);*/
			/*// ������� ��� ���� ��� �� ������������ � ������� ������� �������������
*/
			if(true/*�������������������� <> ������������.��������������������.����������������
	 � �������������������� <> ������������.��������������������.���
	 � ���������������������.��������() <> ������������*/)
			{
				/*��������������������� = ����� �����������������(������������);*/
			}
			/*// ������� ��������� ����������� ������ ���� ��� �� ������������ � ������� ������� �������������
*/
			if(true/*��������������������������������
	 � ��������������������.��������() <> ������������*/)
			{
				/*�������������������� = ����� �����������������(������������);*/
			}
		}
	}
}
