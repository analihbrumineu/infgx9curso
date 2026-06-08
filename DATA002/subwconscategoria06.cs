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
   public class subwconscategoria06 : GXSubfileElement
   {
      private int CatCodigo ;
      private String CatNome ;
      public int getCatCodigo( )
      {
         return CatCodigo ;
      }

      public void setCatCodigo( int value )
      {
         CatCodigo = value;
      }

      public String getCatNome( )
      {
         return CatNome ;
      }

      public void setCatNome( String value )
      {
         CatNome = value;
      }

      public override void clear( )
      {
         CatCodigo = 0 ;
         CatNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getCatCodigo() > ((subwconscategoria06) element).getCatCodigo() ) return 1;
                  if ( getCatCodigo() < ((subwconscategoria06) element).getCatCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getCatNome().CompareTo(((subwconscategoria06) element).getCatNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getCatCodigo() == 0 ) && ( String.CompareOrdinal(getCatNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getCatCodigo() );
               break;
            case 1 :
               cell.setValue( getCatNome() );
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
               return ( (((GUIObjectInt) cell).getValue() == getCatCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCatNome()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setCatCodigo(value.getIntValue());
                  break;
               case 1 :
                  setCatNome(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setCatCodigo(((subwconscategoria06) element).getCatCodigo());
                  return;
               case 1 :
                  setCatNome(((subwconscategoria06) element).getCatNome());
                  return;
         }
      }

   }

}
