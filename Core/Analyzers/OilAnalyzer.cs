using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformerAssessment.Core.Loaders;
using TransformerAssessment.Core.Objects;

namespace TransformerAssessment.Core.Analyzers {
    class OilAnalyzer {
        /// <summary>
        /// List of all the transformers that have been parsed.
        /// </summary>
        private static List<Transformer> _xfmrs;

        /// <summary>
        /// List of transformers after having been analyzed
        /// (sorted by health)
        /// </summary>
        public static List<Transformer> _sortedTransformers;

        /// <summary>
        /// List of all the norms that have been parsed.
        /// </summary>
        private static Norm[] _norms;

        /// <summary>
        /// Method that will be called to analyze the oil in the list of equipment
        /// that has been loaded.
        /// </summary>
        public static void analyzeOil() {
            _xfmrs = EquipmentLoader.getTransformers();
            _norms = NormLoader.getNorms();
            // If either _norms or _xfmrs is neither null or empty, continue with analyzing
            if (_norms != null && _norms.Length > 0 && _xfmrs != null && _xfmrs.Count > 0) {

            }
            // sort the list of XFMRS by their health
            _sortedTransformers = _xfmrs.OrderByDescending(m => m.Health).ToList();
        }

        /// <summary>
        /// Analyzes the transformer test data
        /// </summary>
        private void analyzeTransformers() {

        }

        /// <summary>
        /// Analyzes the LTC test data
        /// </summary>
        private void analyzeTapChangers() {

        }

        /// <summary>
        /// Analyzes the SEL test data
        /// </summary>
        private void analyzeSelectors() {

        }

        /// <summary>
        /// Analyzes the DIV test data
        /// </summary>
        private void analyzeDiverters() {

        }
    }
}
