
using System;
using System.Data.SqlClient;
using V82;
using V82.�����������������;
using V82.�����������;//��������;
using V82.���������������;
using V82.������������;//������;
namespace V82.�����������//��������
{
	public partial class �����������������������������:������������������
	{

		public static �����������������.����������������������������� �����������(decimal ���)
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������]
					,_Fld4064 [SMTP������]
					,_Fld4065 [POP3������]
					,_Fld4066 [����SMTP]
					,_Fld4067 [����POP3]
					,_Fld4068 [�����]
					,_Fld4069 [������]
					,_Fld4070 [���������SMTP��������������]
					,_Fld4071 [�����SMTP]
					,_Fld4072 [������SMTP]
					,_Fld4073 [��������������������]
					,_Fld4074 [��������������������������������]
					,_Fld4075 [��������������������������]
					,_Fld4076 [�����������������������������������]
					,_Fld4077 [���������������������]
					,_Fld4078RRef [��������������]
					,_Fld4079RRef [���������������]
					,_Fld4080RRef [���������������]
					,_Fld4081RRef [���������������]
					,_Fld4082RRef [�������������������]
					,_Fld4083RRef [�����������������������������]
					,_Fld4084 [������������]
					,_Fld4085 [���������������������������������]
					,_Fld4086 [�����������������������������������]
					,_Fld4087 [������������������������������]
					,_Fld4088 [��������������������������������������]
					,_Fld4089RRef [���������������������������������������������]
					,_Fld4090 [���������������������������������������]
					,_Fld4091RRef [��������������������������������������]
					,_Fld4092 [�����������������������������������������]
					,_Fld4093 [�������������������������������������������������]
					,_Fld4094 [��������������������������������������������������]
					,_Fld4095 [�����������������������������������������������������������]
					,_Fld4096 [�����������������������������������������]
					,_Fld4097 [�����������������������������������������������]
					,_Fld4098 [����������������������������������������������������������������������]
					,_Fld4099 [������������������������������������������������������������������������������������]
					,_Fld4100 [��������������������������������������������������������������������������������������]
					,_Fld4101 [�������������������]
					,_Fld4102 [���������������������������]
					,_Fld4103 [����������������������������������������������������]
					,_Fld4104 [�������������������������]
					,_Fld4105 [�����������������������������������������]
					,_Fld4106 [��������������������������������������]
					,_Fld4107RRef [�����������������������]
					,_Fld4108 [�����������������������]
					,_Fld4109 [������������������������]
					From _Reference282(NOLOCK)
					Where _Code=@���";
					�������.Parameters.AddWithValue("���", ���);
					using (var ������� = �������.ExecuteReader())
					{
						if (�������.Read())
						{
							var ������ = new �����������������.�����������������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.SMTP������ = �������.GetString(6);
							������.POP3������ = �������.GetString(7);
							������.����SMTP = �������.GetDecimal(8);
							������.����POP3 = �������.GetDecimal(9);
							������.����� = �������.GetString(10);
							������.������ = �������.GetString(11);
							������.���������SMTP�������������� = ((byte[])�������.GetValue(12))[0]==1?true:false;
							������.�����SMTP = �������.GetString(13);
							������.������SMTP = �������.GetString(14);
							������.�������������������� = �������.GetDecimal(15);
							������.�������������������������������� = ((byte[])�������.GetValue(16))[0]==1?true:false;
							������.�������������������������� = ((byte[])�������.GetValue(17))[0]==1?true:false;
							������.����������������������������������� = �������.GetDecimal(18);
							������.��������������������� = �������.GetString(19);
							//������.�������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(20));
							//������.��������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(21));
							//������.��������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(22));
							//������.��������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(23));
							//������.������������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(24));
							������.����������������������������� = V82.������������/*������*/.���������������������������.������������.��������((byte[])�������.GetValue(25));
							������.������������ = �������.GetString(26);
							������.��������������������������������� = ((byte[])�������.GetValue(27))[0]==1?true:false;
							������.����������������������������������� = ((byte[])�������.GetValue(28))[0]==1?true:false;
							������.������������������������������ = ((byte[])�������.GetValue(29))[0]==1?true:false;
							������.�������������������������������������� = �������.GetDecimal(30);
							//������.��������������������������������������������� = new V82.�����������������.������������((byte[])�������.GetValue(31));
							������.��������������������������������������� = ((byte[])�������.GetValue(32))[0]==1?true:false;
							������.�������������������������������������� = V82.������������/*������*/.�������������������������������������������������.������������.��������((byte[])�������.GetValue(33));
							������.����������������������������������������� = ((byte[])�������.GetValue(34))[0]==1?true:false;
							������.������������������������������������������������� = �������.GetDecimal(35);
							������.�������������������������������������������������� = ((byte[])�������.GetValue(36))[0]==1?true:false;
							������.����������������������������������������������������������� = ((byte[])�������.GetValue(37))[0]==1?true:false;
							������.����������������������������������������� = ((byte[])�������.GetValue(38))[0]==1?true:false;
							������.����������������������������������������������� = ((byte[])�������.GetValue(39))[0]==1?true:false;
							������.���������������������������������������������������������������������� = ((byte[])�������.GetValue(40))[0]==1?true:false;
							������.������������������������������������������������������������������������������������ = ((byte[])�������.GetValue(41))[0]==1?true:false;
							������.�������������������������������������������������������������������������������������� = ((byte[])�������.GetValue(42))[0]==1?true:false;
							������.������������������� = ((byte[])�������.GetValue(43))[0]==1?true:false;
							������.��������������������������� = �������.GetDecimal(44);
							������.���������������������������������������������������� = ((byte[])�������.GetValue(45))[0]==1?true:false;
							������.������������������������� = �������.GetString(46);
							������.����������������������������������������� = ((byte[])�������.GetValue(47))[0]==1?true:false;
							������.�������������������������������������� = ((byte[])�������.GetValue(48))[0]==1?true:false;
							������.����������������������� = V82.������������/*������*/.�����������������������.������������.��������((byte[])�������.GetValue(49));
							������.����������������������� = ((byte[])�������.GetValue(50))[0]==1?true:false;
							������.������������������������ = ((byte[])�������.GetValue(51))[0]==1?true:false;
							return ������;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static ������������������.����������������������������� �������()
		{
			using (var ����������� = new SqlConnection(����������������))
			{
				�����������.Open();
				using (var ������� = �����������.CreateCommand())
				{
					�������.CommandText = @"Select top 1000 
					_IDRRef [������]
					,_Version [������]
					,_Marked [���������������]
					,_IsMetadata [����������������]
					,_Code [���]
					,_Description [������������],_Fld4064 [SMTP������],_Fld4065 [POP3������],_Fld4066 [����SMTP],_Fld4067 [����POP3],_Fld4068 [�����],_Fld4069 [������],_Fld4070 [���������SMTP��������������],_Fld4071 [�����SMTP],_Fld4072 [������SMTP],_Fld4073 [��������������������],_Fld4074 [��������������������������������],_Fld4075 [��������������������������],_Fld4076 [�����������������������������������],_Fld4077 [���������������������],_Fld4078RRef [��������������],_Fld4079RRef [���������������],_Fld4080RRef [���������������],_Fld4081RRef [���������������],_Fld4082RRef [�������������������],_Fld4083RRef [�����������������������������],_Fld4084 [������������],_Fld4085 [���������������������������������],_Fld4086 [�����������������������������������],_Fld4087 [������������������������������],_Fld4088 [��������������������������������������],_Fld4089RRef [���������������������������������������������],_Fld4090 [���������������������������������������],_Fld4091RRef [��������������������������������������],_Fld4092 [�����������������������������������������],_Fld4093 [�������������������������������������������������],_Fld4094 [��������������������������������������������������],_Fld4095 [�����������������������������������������������������������],_Fld4096 [�����������������������������������������],_Fld4097 [�����������������������������������������������],_Fld4098 [����������������������������������������������������������������������],_Fld4099 [������������������������������������������������������������������������������������],_Fld4100 [��������������������������������������������������������������������������������������],_Fld4101 [�������������������],_Fld4102 [���������������������������],_Fld4103 [����������������������������������������������������],_Fld4104 [�������������������������],_Fld4105 [�����������������������������������������],_Fld4106 [��������������������������������������],_Fld4107RRef [�����������������������],_Fld4108 [�����������������������],_Fld4109 [������������������������]
		 From _Reference282(NOLOCK)";
					var ������� = new V82.������������������.�����������������������������();
					using (var ������� = �������.ExecuteReader())
					{
						while (�������.Read())
						{
							var ������ = new �����������������.�����������������������������();
		
							������.������ = new Guid((byte[])�������.GetValue(0));
							var ����������� = ((byte[])�������.GetValue(1));
							Array.Reverse(�����������);
							������.������ =  BitConverter.ToInt64(�����������, 0);
							������.��������������� = ((byte[])�������.GetValue(2))[0]==1?true:false;
							������.���������������� = ((byte[])�������.GetValue(3))[0]==1?true:false;
							������.��� = �������.GetString(4);
							������.������������ = �������.GetString(5);
							������.SMTP������ = �������.GetString(6);
							������.POP3������ = �������.GetString(7);
							������.����SMTP = �������.GetDecimal(8);
							������.����POP3 = �������.GetDecimal(9);
							������.����� = �������.GetString(10);
							������.������ = �������.GetString(11);
							������.���������SMTP�������������� = ((byte[])�������.GetValue(12))[0]==1?true:false;
							������.�����SMTP = �������.GetString(13);
							������.������SMTP = �������.GetString(14);
							������.�������������������� = �������.GetDecimal(15);
							������.�������������������������������� = ((byte[])�������.GetValue(16))[0]==1?true:false;
							������.�������������������������� = ((byte[])�������.GetValue(17))[0]==1?true:false;
							������.����������������������������������� = �������.GetDecimal(18);
							������.��������������������� = �������.GetString(19);
							//������.�������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(20));
							//������.��������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(21));
							//������.��������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(22));
							//������.��������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(23));
							//������.������������������� = new V82.�����������������.���������������������������((byte[])�������.GetValue(24));
							������.����������������������������� = V82.������������/*������*/.���������������������������.������������.��������((byte[])�������.GetValue(25));
							������.������������ = �������.GetString(26);
							������.��������������������������������� = ((byte[])�������.GetValue(27))[0]==1?true:false;
							������.����������������������������������� = ((byte[])�������.GetValue(28))[0]==1?true:false;
							������.������������������������������ = ((byte[])�������.GetValue(29))[0]==1?true:false;
							������.�������������������������������������� = �������.GetDecimal(30);
							//������.��������������������������������������������� = new V82.�����������������.������������((byte[])�������.GetValue(31));
							������.��������������������������������������� = ((byte[])�������.GetValue(32))[0]==1?true:false;
							������.�������������������������������������� = V82.������������/*������*/.�������������������������������������������������.������������.��������((byte[])�������.GetValue(33));
							������.����������������������������������������� = ((byte[])�������.GetValue(34))[0]==1?true:false;
							������.������������������������������������������������� = �������.GetDecimal(35);
							������.�������������������������������������������������� = ((byte[])�������.GetValue(36))[0]==1?true:false;
							������.����������������������������������������������������������� = ((byte[])�������.GetValue(37))[0]==1?true:false;
							������.����������������������������������������� = ((byte[])�������.GetValue(38))[0]==1?true:false;
							������.����������������������������������������������� = ((byte[])�������.GetValue(39))[0]==1?true:false;
							������.���������������������������������������������������������������������� = ((byte[])�������.GetValue(40))[0]==1?true:false;
							������.������������������������������������������������������������������������������������ = ((byte[])�������.GetValue(41))[0]==1?true:false;
							������.�������������������������������������������������������������������������������������� = ((byte[])�������.GetValue(42))[0]==1?true:false;
							������.������������������� = ((byte[])�������.GetValue(43))[0]==1?true:false;
							������.��������������������������� = �������.GetDecimal(44);
							������.���������������������������������������������������� = ((byte[])�������.GetValue(45))[0]==1?true:false;
							������.������������������������� = �������.GetString(46);
							������.����������������������������������������� = ((byte[])�������.GetValue(47))[0]==1?true:false;
							������.�������������������������������������� = ((byte[])�������.GetValue(48))[0]==1?true:false;
							������.����������������������� = V82.������������/*������*/.�����������������������.������������.��������((byte[])�������.GetValue(49));
							������.����������������������� = ((byte[])�������.GetValue(50))[0]==1?true:false;
							������.������������������������ = ((byte[])�������.GetValue(51))[0]==1?true:false;
							�������.Add(������);
						}
							return �������;
					}
				}
			}
		}

		public static V82.�����������������.����������������������������� ��������������()
		{
			var ������ = new V82.�����������������.�����������������������������();
			������._�������� = true;
			������.������ = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			������.��������� = false;
			������.SMTP������ = "";
			������.POP3������ = "";
			������.����� = "";
			������.������ = "";
			������.�����SMTP = "";
			������.������SMTP = "";
			������.��������������������� = "";
			������.������������ = "";
			������.������������������������� = "";
			������.�������������� = new V82.�����������������.���������������������������();
			������.��������������� = new V82.�����������������.���������������������������();
			������.��������������� = new V82.�����������������.���������������������������();
			������.��������������� = new V82.�����������������.���������������������������();
			������.������������������� = new V82.�����������������.���������������������������();
			������.����������������������������� = V82.������������/*������*/.���������������������������.������������;
			������.��������������������������������������������� = new V82.�����������������.������������();
			������.�������������������������������������� = V82.������������/*������*/.�������������������������������������������������.������������;
			������.����������������������� = V82.������������/*������*/.�����������������������.������������;
			return ������;
		}
	}
}
