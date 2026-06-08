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
   public class subtfilme22 : GXSubfileElement
   {
      private int FilDirCodigo ;
      private String FilDirNome ;
      public int getFilDirCodigo( )
      {
         return FilDirCodigo ;
      }

      public void setFilDirCodigo( int value )
      {
         FilDirCodigo = value;
      }

      public String getFilDirNome( )
      {
         return FilDirNome ;
      }

      public void setFilDirNome( String value )
      {
         FilDirNome = value;
      }

      public override void clear( )
      {
         FilDirCodigo = 0 ;
         FilDirNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilDirCodigo() > ((subtfilme22) element).getFilDirCodigo() ) return 1;
                  if ( getFilDirCodigo() < ((subtfilme22) element).getFilDirCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getFilDirNome().CompareTo(((subtfilme22) element).getFilDirNome()) ;
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
         return ( ( getFilDirCodigo() == 0 ) && ( String.CompareOrdinal(getFilDirNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) || insertedNotUserModified() )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilDirCodigo() );
               break;
            case 1 :
               cell.setValue( getFilDirNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getFilDirCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilDirNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setFilDirCodigo(value.getIntValue());
                  break;
               case 1 :
                  setFilDirNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setFilDirCodigo(((subtfilme22) element).getFilDirCodigo());
                  return;
               case 1 :
                  setFilDirNome(((subtfilme22) element).getFilDirNome());
                  return;
         }
      }

   }

}
