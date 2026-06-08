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
   public class subwconscidade03 : GXSubfileElement
   {
      private int CidCodigo ;
      private String EstUF ;
      private String CidNome ;
      public int getCidCodigo( )
      {
         return CidCodigo ;
      }

      public void setCidCodigo( int value )
      {
         CidCodigo = value;
      }

      public String getEstUF( )
      {
         return EstUF ;
      }

      public void setEstUF( String value )
      {
         EstUF = value;
      }

      public String getCidNome( )
      {
         return CidNome ;
      }

      public void setCidNome( String value )
      {
         CidNome = value;
      }

      public override void clear( )
      {
         CidCodigo = 0 ;
         EstUF = "" ;
         CidNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getCidCodigo() > ((subwconscidade03) element).getCidCodigo() ) return 1;
                  if ( getCidCodigo() < ((subwconscidade03) element).getCidCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getEstUF().CompareTo(((subwconscidade03) element).getEstUF()) ;
               case 2 :
                  return  getCidNome().CompareTo(((subwconscidade03) element).getCidNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getCidCodigo() == 0 ) && ( String.CompareOrdinal(getEstUF().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getCidNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getCidCodigo() );
               break;
            case 1 :
               cell.setValue( getEstUF() );
               break;
            case 2 :
               cell.setValue( getCidNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getCidCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getEstUF()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCidNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setCidCodigo(value.getIntValue());
                  break;
               case 1 :
                  setEstUF(value.getStringValue());
                  break;
               case 2 :
                  setCidNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setCidCodigo(((subwconscidade03) element).getCidCodigo());
                  return;
               case 1 :
                  setEstUF(((subwconscidade03) element).getEstUF());
                  return;
               case 2 :
                  setCidNome(((subwconscidade03) element).getCidNome());
                  return;
         }
      }

   }

}
