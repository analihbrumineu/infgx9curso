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
   public class subwgx003010 : GXSubfileElement
   {
      private int FilCodigo ;
      private String FilNome ;
      public int getFilCodigo( )
      {
         return FilCodigo ;
      }

      public void setFilCodigo( int value )
      {
         FilCodigo = value;
      }

      public String getFilNome( )
      {
         return FilNome ;
      }

      public void setFilNome( String value )
      {
         FilNome = value;
      }

      public override void clear( )
      {
         FilCodigo = 0 ;
         FilNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilCodigo() > ((subwgx003010) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwgx003010) element).getFilCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getFilNome().CompareTo(((subwgx003010) element).getFilNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getFilCodigo() == 0 ) && ( String.CompareOrdinal(getFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilCodigo() );
               break;
            case 1 :
               cell.setValue( getFilNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setFilCodigo(value.getIntValue());
                  break;
               case 1 :
                  setFilNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setFilCodigo(((subwgx003010) element).getFilCodigo());
                  return;
               case 1 :
                  setFilNome(((subwgx003010) element).getFilNome());
                  return;
         }
      }

   }

}
