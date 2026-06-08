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
   public class subwconsestado08 : GXSubfileElement
   {
      private int EstCodigo ;
      private String EstUF ;
      private String EstNome ;
      public int getEstCodigo( )
      {
         return EstCodigo ;
      }

      public void setEstCodigo( int value )
      {
         EstCodigo = value;
      }

      public String getEstUF( )
      {
         return EstUF ;
      }

      public void setEstUF( String value )
      {
         EstUF = value;
      }

      public String getEstNome( )
      {
         return EstNome ;
      }

      public void setEstNome( String value )
      {
         EstNome = value;
      }

      public override void clear( )
      {
         EstCodigo = 0 ;
         EstUF = "" ;
         EstNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getEstCodigo() > ((subwconsestado08) element).getEstCodigo() ) return 1;
                  if ( getEstCodigo() < ((subwconsestado08) element).getEstCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getEstUF().CompareTo(((subwconsestado08) element).getEstUF()) ;
               case 2 :
                  return  getEstNome().CompareTo(((subwconsestado08) element).getEstNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getEstCodigo() == 0 ) && ( String.CompareOrdinal(getEstUF().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getEstNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getEstCodigo() );
               break;
            case 1 :
               cell.setValue( getEstUF() );
               break;
            case 2 :
               cell.setValue( getEstNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getEstCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getEstUF()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getEstNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setEstCodigo(value.getIntValue());
                  break;
               case 1 :
                  setEstUF(value.getStringValue());
                  break;
               case 2 :
                  setEstNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setEstCodigo(((subwconsestado08) element).getEstCodigo());
                  return;
               case 1 :
                  setEstUF(((subwconsestado08) element).getEstUF());
                  return;
               case 2 :
                  setEstNome(((subwconsestado08) element).getEstNome());
                  return;
         }
      }

   }

}
