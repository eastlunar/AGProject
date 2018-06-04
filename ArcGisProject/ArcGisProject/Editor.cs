using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;

namespace ArcGisProject
{
    public partial class Editor : Form
    {
        private IMapControl3 m_pMapControl;
        private ILayer m_pCurrentLayer;
        private IMap m_pMap;
        private IFeature m_pEditFeature;
        private IPoint m_pPoint;
        //private IDisplayFeedback m_pFeedback;
        private bool m_bInUse;
        private IPointCollection m_pPointCollection;
        private ISelection m_Selection = null;
        private IGeometryCollection m_GeometryCollection = null;
        //public static IEnumFeature SelEnumFeature = null;
        
        public Editor()
        {
            InitializeComponent();
        }

        public Editor(IMapControl3 m_pMapControl) 
        {
            this.m_pMapControl = m_pMapControl;
        }
    }
}
