module Research.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.Browser

let root =
  div
    [ClassName "content"]
    [ 
      h1 [ClassName "title"] [str "Research"]
      p []
        [
          str "Research in the AI Lab is in two major directions:"
          ul []
            [
              li [] [str "Multi-Agent Modeling"]
              li [] [str "Evolutionary Computation"]
            ]
        ]
      div [ClassName "card"]
        [
          // div [ClassName "card-header-title"] [str ]
          div [ClassName "card-content"]
            [
              strong [] [str "Multi-Agent Modeling"]
              p []
                [
                  str """
                  Agents are computational entities that can be viewed as perceiving 
                  their environment through sensors and acting on the environment through 
                  affectors. Multi-agent systems are collections interacting, intelligent 
                  autonomous agents that are in pursuit of some set of goals or need to 
                  perform some set of tasks. Distributed AI relates to the construction 
                  and application of multi-agent systems.                  
                  """
                ]
              p []
                [
                  str """
                  Multi-agent systems have become of increased interest in the past 
                  decade for the following reasons. The first reason is that multi-agent 
                  systems can be a useful modeling tool in the design of modern computing 
                  platforms which are distributed, large, and heterogeneous in nature. 
                  A second reason is that multi-agent systems can be useful in understanding 
                  and modeling theories of the evolution of complex social systems. 
                  A brief description of a current laboratory project funded by 
                  the National Science Foundation Intelligent Systems division, 
                  IIS-9907257 that relates to the latter reason is now given.
                  """
                ]
              p [] [em [] [str "Project Summary"]]
              p []
                [
                  str """
                  A state is among the most sophisticated and powerful structures that 
                  has emerged from the social evolution process. In the modern world 
                  these are termed "nation states’ with a government composed of a 
                  hierarchical decision-making structure where the decision-makers are 
                  either elected or appointed. States are supported by various economies 
                  and are able to interact with each other via warfare, trade, etc. 
                  Most states in the ancient world-often called archaic states-were 
                  ruled by hereditary royal families. These archaic states exhibited 
                  much internal diversity with populations numbering from tens of 
                  thousands to millions. They had a bureaucracy, organized religion, 
                  a military presence, large urban centers, public buildings, 
                  public works, and services provided by various professional specialists. 
                  The state itself could enter into warfare and trade-based 
                  relationships with other states and less complex neighbors.
                  """
                ]
              p []
                [
                  str """
                  The process by which complex social entities such as the state emerged from 
                  lower level structures and other supporting economies has long been of prime
                  interest to anthropologists and other disciplines as well. This is because
                  the emergence of such a social structure can have a profound impact on the 
                  societies’ physical and social environment. However, the task of developing 
                  realistic computational models that aid in the understanding and explanation 
                  of state emergence has been a difficult one. This is the result of two basic 
                  factors:
                  """
                  ol []
                   [
                     li [] [str """The process of state formation inherently takes place on 
                     a variety of temporal and spatial scales. The emergence of hierarchical 
                     decision-making can be viewed as an adaptation that allows decision-makers 
                     to specialize their decisions to particular spatial and temporal scales."""]

                     li [] [str """The formation of the state is a complex process that is 
                     fundamentally directed by the social variables but requiring dynamic 
                     interaction between the emergent system and its environment. Identifying 
                     the nature of these interactions is one of the reasons why the process of 
                     state formation is of such interest."""]
                   ]
                ]
              p []
                [
                  str """The goal of this project is to produce a large-scale knowledge-based 
                  computational model of the origins of the Zapotec State, centered at 
                  Monte Alban, in the Valley of Oaxaca, Mexico. State formation took 
                  place between 1400 BC. and 300 BC. While archaic states have emerged 
                  in various parts of the world, the relative isolation of the valley 
                  allowed the processes of social evolution to be more visible there. 
                  Extensive surveys of the valley were undertaken by the Oaxaca Settlement 
                  Pattern Project in the 1970’s and 1980’s. The location and features of 
                  nearly 3,000 sites dating from the archaic period (8000 BC.) to Late 
                  Monte Alban V (just prior to the arrival of the Spaniards) were documented. 
                  Several hundred variables were recorded for each site. These data are the 
                  basis for generating the knowledge used in our model. Over the past 5 
                  years we have developed a database to house this data. We have used 
                  techniques from machine learning (genetic and cultural algorithms) and 
                  data mining to extract information about site settlement decision-making, 
                  as well as other facets of the social evolution process. The project has 
                  three phases:"""
                ]
              p []
                [
                  em [] [str "Year 1: "]
                  span [] [str """We will complete the analysis of the Oaxaca Settlement 
                  Survey data in order to produce knowledge about warfare, trade, and 
                  economic decisions. The construction of the basic computational model 
                  of state formation will begin. The approach will center on the use of 
                  paradigms from evolutionary learning, such as Genetic and Cultural 
                  Algorithms."""]
                ]
              p []
                [
                  em [] [str "Year 2: "]
                  span [] [str """n this phase the development of a prototype model of state 
                  evolution will take place. Since the Valley of Oaxaca consists of 5 
                  different sub-regions, each interacting with the emerging state 
                  in different ways at different times, a distributed model is 
                  proposed here. The complexity of the model will require that 
                  each regional model runs on a separate network site, and interact 
                  with each other at different temporal and spatial scales through 
                  the network."""]
                ]            
              p []
                [
                  em [] [str "Year 3: "]
                  span [] [str """The model will then be used to test a various 
                  hypotheses concerning the emergence of complex systems. These 
                  hypotheses relate to the importance of processes such as chiefly 
                  cycling, hydraulic despotism, social circumscription, consolidation 
                  of resources, and territorial expansion among others. The results 
                  of the simulations will be compared with the patterns observed in 
                  the actual site settlement data for the valley."""]
                ]                 
            ]
        ]
      br[]
      div [ClassName "card"]
        [
          // div [ClassName "card-header-title"] 
          div [ClassName "card-content"] 
            [
              strong [] [str "Evolutionary Computation"]
              p[]
                [
                  str """The laboratory has also been a focus for the development of 
                  evolution-based machine learning tools for use in modeling the cultural 
                  evolution in multi-agent systems and for data-mining of the large-scale 
                  data sets associated with such systems. Dr. Reynolds has developed 
                  Cultural Algorithms, a framework for modeling the evolution of social 
                  systems. Cultural Algorithms have been used to solve a variety of real 
                  world problems, including function optimization, knowledge base design 
                  and re-engineering, software design, in addition to the application 
                  above. Over 100 articles and two books have been produced by 
                  laboratory research in the past."""   
                ]
            ]
        ]
    ] 
