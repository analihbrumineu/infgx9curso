using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subwgx001020 : GXSubfileElement
   {
      private int PesCodigo ;
      private String PesCPF ;
      private DateTime PesDatNascimento ;
      public int getPesCodigo( )
      {
         return PesCodigo ;
      }

      public void setPesCodigo( int value )
      {
         PesCodigo = value;
      }

      public String getPesCPF( )
      {
         return PesCPF ;
      }

      public void setPesCPF( String value )
      {
         PesCPF = value;
      }

      public DateTime getPesDatNascimento( )
      {
         return PesDatNascimento ;
      }

      public void setPesDatNascimento( DateTime value )
      {
         PesDatNascimento = value;
      }

      public override void clear( )
      {
         PesCodigo = 0 ;
         PesCPF = "" ;
         PesDatNascimento = DateTime.MinValue ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getPesCodigo() > ((subwgx001020) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwgx001020) element).getPesCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getPesCPF().CompareTo(((subwgx001020) element).getPesCPF()) ;
               case 2 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getPesDatNascimento()) , GxConvert.AnyDateToJDate(((subwgx001020) element).getPesDatNascimento()) );
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesCPF().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getPesDatNascimento() == DateTime.MinValue ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getPesCodigo() );
               break;
            case 1 :
               cell.setValue( getPesCPF() );
               break;
            case 2 :
               cell.setValue( GxConvert.AnyDateToJDate(getPesDatNascimento()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getPesCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesCPF()) == 0) );
            case 2 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getPesDatNascimento()))) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(value.getIntValue());
                  break;
               case 1 :
                  setPesCPF(value.getStringValue());
                  break;
               case 2 :
                  setPesDatNascimento(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(((subwgx001020) element).getPesCodigo());
                  return;
               case 1 :
                  setPesCPF(((subwgx001020) element).getPesCPF());
                  return;
               case 2 :
                  setPesDatNascimento(((subwgx001020) element).getPesDatNascimento());
                  return;
         }
      }

   }

}
