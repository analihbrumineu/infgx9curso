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
   public class subwmovdocliente06 : GXSubfileElement
   {
      private short VDepende ;
      private int VPesCodNaGrid ;
      private String VPesNomNaGrid ;
      private long VTotDevolucao ;
      private long VTotCancelamento ;
      public short getVDepende( )
      {
         return VDepende ;
      }

      public void setVDepende( short value )
      {
         VDepende = value;
      }

      public int getVPesCodNaGrid( )
      {
         return VPesCodNaGrid ;
      }

      public void setVPesCodNaGrid( int value )
      {
         VPesCodNaGrid = value;
      }

      public String getVPesNomNaGrid( )
      {
         return VPesNomNaGrid ;
      }

      public void setVPesNomNaGrid( String value )
      {
         VPesNomNaGrid = value;
      }

      public long getVTotDevolucao( )
      {
         return VTotDevolucao ;
      }

      public void setVTotDevolucao( long value )
      {
         VTotDevolucao = value;
      }

      public long getVTotCancelamento( )
      {
         return VTotCancelamento ;
      }

      public void setVTotCancelamento( long value )
      {
         VTotCancelamento = value;
      }

      public override void clear( )
      {
         VDepende = 0 ;
         VPesCodNaGrid = 0 ;
         VPesNomNaGrid = "" ;
         VTotDevolucao = 0 ;
         VTotCancelamento = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getVDepende() > ((subwmovdocliente06) element).getVDepende() ) return 1;
                  if ( getVDepende() < ((subwmovdocliente06) element).getVDepende() ) return -1;
                  return 0;
               case 1 :
                  if ( getVPesCodNaGrid() > ((subwmovdocliente06) element).getVPesCodNaGrid() ) return 1;
                  if ( getVPesCodNaGrid() < ((subwmovdocliente06) element).getVPesCodNaGrid() ) return -1;
                  return 0;
               case 2 :
                  return  getVPesNomNaGrid().CompareTo(((subwmovdocliente06) element).getVPesNomNaGrid()) ;
               case 3 :
                  if ( getVTotDevolucao() > ((subwmovdocliente06) element).getVTotDevolucao() ) return 1;
                  if ( getVTotDevolucao() < ((subwmovdocliente06) element).getVTotDevolucao() ) return -1;
                  return 0;
               case 4 :
                  if ( getVTotCancelamento() > ((subwmovdocliente06) element).getVTotCancelamento() ) return 1;
                  if ( getVTotCancelamento() < ((subwmovdocliente06) element).getVTotCancelamento() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getVDepende() == 0 ) && ( getVPesCodNaGrid() == 0 ) && ( String.CompareOrdinal(getVPesNomNaGrid().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getVTotDevolucao() == 0 ) && ( getVTotCancelamento() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVDepende() );
               break;
            case 1 :
               cell.setValue( getVPesCodNaGrid() );
               break;
            case 2 :
               cell.setValue( getVPesNomNaGrid() );
               break;
            case 3 :
               cell.setValue( getVTotDevolucao() );
               break;
            case 4 :
               cell.setValue( getVTotCancelamento() );
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
               return ( (((GUIObjectShort) cell).getValue() == getVDepende()) );
            case 1 :
               return ( (((GUIObjectInt) cell).getValue() == getVPesCodNaGrid()) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVPesNomNaGrid()) == 0) );
            case 3 :
               return ( (((GUIObjectLong) cell).getValue() == getVTotDevolucao()) );
            case 4 :
               return ( (((GUIObjectLong) cell).getValue() == getVTotCancelamento()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setVDepende(value.getShortValue());
                  break;
               case 1 :
                  setVPesCodNaGrid(value.getIntValue());
                  break;
               case 2 :
                  setVPesNomNaGrid(value.getStringValue());
                  break;
               case 3 :
                  setVTotDevolucao(value.getLongValue());
                  break;
               case 4 :
                  setVTotCancelamento(value.getLongValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVDepende(((subwmovdocliente06) element).getVDepende());
                  return;
               case 1 :
                  setVPesCodNaGrid(((subwmovdocliente06) element).getVPesCodNaGrid());
                  return;
               case 2 :
                  setVPesNomNaGrid(((subwmovdocliente06) element).getVPesNomNaGrid());
                  return;
               case 3 :
                  setVTotDevolucao(((subwmovdocliente06) element).getVTotDevolucao());
                  return;
               case 4 :
                  setVTotCancelamento(((subwmovdocliente06) element).getVTotCancelamento());
                  return;
         }
      }

   }

}
