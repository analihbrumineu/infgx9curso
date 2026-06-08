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
   public class subwconscliente11 : GXSubfileElement
   {
      private int PesCodigo ;
      private String PesNome ;
      public int getPesCodigo( )
      {
         return PesCodigo ;
      }

      public void setPesCodigo( int value )
      {
         PesCodigo = value;
      }

      public String getPesNome( )
      {
         return PesNome ;
      }

      public void setPesNome( String value )
      {
         PesNome = value;
      }

      public override void clear( )
      {
         PesCodigo = 0 ;
         PesNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getPesCodigo() > ((subwconscliente11) element).getPesCodigo() ) return 1;
                  if ( getPesCodigo() < ((subwconscliente11) element).getPesCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getPesNome().CompareTo(((subwconscliente11) element).getPesNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getPesCodigo() == 0 ) && ( String.CompareOrdinal(getPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getPesCodigo() );
               break;
            case 1 :
               cell.setValue( getPesNome() );
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
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesNome()) == 0) );
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
                  setPesNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setPesCodigo(((subwconscliente11) element).getPesCodigo());
                  return;
               case 1 :
                  setPesNome(((subwconscliente11) element).getPesNome());
                  return;
         }
      }

   }

}
