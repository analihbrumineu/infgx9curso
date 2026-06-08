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
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subtcliente40 : GXSubfileElement
   {
      private int PesDepCodigo ;
      private String PesDepNome ;
      public int getPesDepCodigo( )
      {
         return PesDepCodigo ;
      }

      public void setPesDepCodigo( int value )
      {
         PesDepCodigo = value;
      }

      public String getPesDepNome( )
      {
         return PesDepNome ;
      }

      public void setPesDepNome( String value )
      {
         PesDepNome = value;
      }

      public override void clear( )
      {
         PesDepCodigo = 0 ;
         PesDepNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getPesDepCodigo() > ((subtcliente40) element).getPesDepCodigo() ) return 1;
                  if ( getPesDepCodigo() < ((subtcliente40) element).getPesDepCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getPesDepNome().CompareTo(((subtcliente40) element).getPesDepNome()) ;
         }
         return 0;
      }

      public override int isChanged( )
      {
         return (!userModified && (!inserted
         ))?0:1;
      }

      public override bool isEmpty( )
      {
         return ( ( getPesDepCodigo() == 0 ) && ( String.CompareOrdinal(getPesDepNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) || insertedNotUserModified() )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getPesDepCodigo() );
               break;
            case 1 :
               cell.setValue( getPesDepNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getPesDepCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getPesDepNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setPesDepCodigo(value.getIntValue());
                  break;
               case 1 :
                  setPesDepNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setPesDepCodigo(((subtcliente40) element).getPesDepCodigo());
                  return;
               case 1 :
                  setPesDepNome(((subtcliente40) element).getPesDepNome());
                  return;
         }
      }

   }

}
