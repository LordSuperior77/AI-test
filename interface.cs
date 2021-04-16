public interface INeuralLayer : IList<INeuron>  
{  
    void Pulse(INeuralNet net);  
    void ApplyLearning(INeuralNet net);  
} 