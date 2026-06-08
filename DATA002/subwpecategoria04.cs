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
   public class subwpecategoria04 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int CatCodigo ;
      private String CatNome ;
      public String getVVisualizar( )
      {
         return VVisualizar ;
      }

      public void setVVisualizar( String value )
      {
         VVisualizar = value;
      }

      public String getVEditar( )
      {
         return VEditar ;
      }

      public void setVEditar( String value )
      {
         VEditar = value;
      }

      public String getVExcluir( )
      {
         return VExcluir ;
      }

      public void setVExcluir( String value )
      {
         VExcluir = value;
      }

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
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
         CatCodigo = 0 ;
         CatNome = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVVisualizar().CompareTo(((subwpecategoria04) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpecategoria04) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpecategoria04) element).getVExcluir()) ;
               case 3 :
                  if ( getCatCodigo() > ((subwpecategoria04) element).getCatCodigo() ) return 1;
                  if ( getCatCodigo() < ((subwpecategoria04) element).getCatCodigo() ) return -1;
                  return 0;
               case 4 :
                  return  getCatNome().CompareTo(((subwpecategoria04) element).getCatNome()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getCatCodigo() == 0 ) && ( String.CompareOrdinal(getCatNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVVisualizar() );
               break;
            case 1 :
               cell.setValue( getVEditar() );
               break;
            case 2 :
               cell.setValue( getVExcluir() );
               break;
            case 3 :
               cell.setValue( getCatCodigo() );
               break;
            case 4 :
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
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVVisualizar()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVExcluir()) == 0) );
            case 3 :
               return ( (((GUIObjectInt) cell).getValue() == getCatCodigo()) );
            case 4 :
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
                  break;
               case 1 :
                  break;
               case 2 :
                  break;
               case 3 :
                  setCatCodigo(value.getIntValue());
                  break;
               case 4 :
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
                  setVVisualizar(((subwpecategoria04) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpecategoria04) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpecategoria04) element).getVExcluir());
                  return;
               case 3 :
                  setCatCodigo(((subwpecategoria04) element).getCatCodigo());
                  return;
               case 4 :
                  setCatNome(((subwpecategoria04) element).getCatNome());
                  return;
         }
      }

   }

}
