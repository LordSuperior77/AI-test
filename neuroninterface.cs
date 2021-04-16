public interface INeuron : INeuronSignal, INeuronReceptor  
{  
    void Pulse(INeuralLayer layer);  
    void ApplyLearning(INeuralLayer layer);  
    NeuralFactor Bias { get; set; }  
    double BiasWeight { get; set; }  
    double Error { get; set; }  
} 